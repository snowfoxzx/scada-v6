﻿// Depends on jquery, scada-common.js, mimic-common.js, mimic-model.js, mimic-render.js

const UPDATE_RATE = 1000;
const mimic = new rs.mimic.Mimic();
const unitedRenderer = new rs.mimic.UnitedRenderer(mimic, true);
const updateQueue = [];

var rootPath = "/";
var mimicKey = "0";
var splitter = null;
var mimicWrapperElem = $();

function bindEvents() {
    $(window).on("resize", function () {
        updateLayout();
    });

    $("#btnCut").on("click", function () {
        testEdit();
    });
}

function updateLayout() {
    let windowHeight = $(window).height();
    let toolbarHeight = $("#divToolbar").outerHeight();

    let windowWidth = $(window).width();
    let leftPanelWidth = $("#divLeftPanel").width();
    let splitterWidth = $("#divSplitter").width();

    $("#divMain").outerHeight(windowHeight - toolbarHeight);
    $("#divMimicWrapper").outerWidth(windowWidth - leftPanelWidth - splitterWidth);
}

function initTweakpane() {
    let PARAMS = {
        text: 'hello, world',
        number: 1.0
    };

    let containerElem = $("<div id='tweakpane'></div>").appendTo("#divLeftPanel");

    let pane = new Pane({
        container: containerElem[0]
    });

    pane.addBinding(PARAMS, "text");
    pane.addBinding(PARAMS, "number");
}

async function loadMimic() {
    let result = await mimic.load(getLoaderUrl(), mimicKey);

    if (result.ok) {
        mimicWrapperElem.append(unitedRenderer.createMimicDom());
    } else {
        // show error
    }
}

async function startUpdatingBackend() {
    await postUpdates();
    setTimeout(startUpdatingBackend, UPDATE_RATE);
}

function getLoaderUrl() {
    return rootPath + "Api/MimicEditor/Loader/";
}

function getUpdaterUrl() {
    return rootPath + "Api/MimicEditor/Updater/";
}

async function postUpdates() {
    while (updateQueue.length > 0) {
        let updateDTO = updateQueue.shift();
        let result = await postUpdate(updateDTO);

        if (!result) {
            updateQueue.unshift(updateDTO);
            break;
        }
    }
}

async function postUpdate(updateDTO) {
    try {
        let response = await fetch(getUpdaterUrl() + "UpdateMimic", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(updateDTO)
        });

        if (response.ok) {
            let dto = await response.json();

            if (!dto.ok) {
                console.error("Error processing update: " + dto.msg);
            }
        }

        return true;
    } catch {
        return false;
    }
}

function testEdit() {
    let component = mimic.componentMap.get(1);

    if (component) {
        // update client side
        const textValue = "Hello";
        component.properties.text = textValue;
        unitedRenderer.updateComponentDom(component);

        // update server side
        let change = Change.updateComponent(component.id, { text: textValue });
        let updateDTO = new UpdateDTO(mimicKey, change);
        updateQueue.push(updateDTO);
    }
}

$(async function () {
    splitter = new Splitter("divSplitter");
    mimicWrapperElem = $("#divMimicWrapper");

    bindEvents();
    updateLayout();
    initTweakpane();
    await loadMimic();
    await startUpdatingBackend();
});
