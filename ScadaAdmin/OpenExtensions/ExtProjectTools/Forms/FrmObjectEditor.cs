﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Admin.Extensions.ExtProjectTools.Properties;
using Scada.Admin.Project;
using Scada.Data.Entities;
using Scada.Data.Tables;
using Scada.Forms;
using Scada.Lang;
using System.Collections.Generic;
using WinControls;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Scada.Admin.Extensions.ExtProjectTools.Forms
{
    /// <summary>
    /// Represents an object editor form.
    /// <para>Представляет форму редактора проектов.</para>
    /// </summary>
    public partial class FrmObjectEditor : Form, IChildForm
    {
        private readonly IAdminContext adminContext;
        private readonly ConfigDatabase configDatabase;

        private TreeNode selectedNode;
        private Obj selectedObj;
        private bool changing;


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        private FrmObjectEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public FrmObjectEditor(IAdminContext adminContext, ConfigDatabase configDatabase)
            : this()
        {
            this.adminContext = adminContext ?? throw new ArgumentNullException(nameof(adminContext));
            this.configDatabase = configDatabase ?? throw new ArgumentNullException(nameof(configDatabase));

            selectedNode = null;
            selectedObj = null;
            changing = false;

            ChildFormTag = new ChildFormTag(new ChildFormOptions { Image = Resources.obj });
            IsClosed = false;
        }


        /// <summary>
        /// Gets or sets the object associated with the form.
        /// </summary>
        public ChildFormTag ChildFormTag { get; set; }

        /// <summary>
        /// Gets a value indicating whether the form has been closed.
        /// </summary>
        public bool IsClosed { get; private set; }


        /// <summary>
        /// Adds images to the image list.
        /// </summary>
        private void AddTreeViewImages()
        {
            ilTree.Images.Add("obj.png", Resources.obj);
        }

        /// <summary>
        /// Shows objects in the editor.
        /// </summary>
        private void ShowData()
        {
            FillParentObjects();
            FillTreeView();
            ChildFormTag.Modified = configDatabase.ObjTable.Modified;
        }

        /// <summary>
        /// Fills the combo box with the parent objects.
        /// </summary>
        private void FillParentObjects()
        {
            Obj emptyObj = new() { ObjNum = 0, Name = " " };
            List<Obj> objs = new(configDatabase.ObjTable.ItemCount + 1) { emptyObj };
            objs.AddRange(configDatabase.ObjTable.Enumerate().OrderBy(o => o.Name));

            changing = true;
            cbParentObj.ValueMember = "ObjNum";
            cbParentObj.DisplayMember = "Name";
            cbParentObj.DataSource = objs;
            cbParentObj.SelectedValue = 0;
            changing = false;
        }

        /// <summary>
        /// Fills the object tree.
        /// </summary>
        private void FillTreeView()
        {
            try
            {
                tvObj.BeginUpdate();
                tvObj.Nodes.Clear();

                if (configDatabase.ObjTable.ItemCount > 0)
                {
                    AddChildObjects(GetParentObjIndex(), 0, null);

                    if (tvObj.Nodes.Count > 0)
                        tvObj.SelectedNode = tvObj.Nodes[0];
                }
            }
            finally
            {
                tvObj.EndUpdate();
            }
        }

        /// <summary>
        /// Gets an index of the ParentObjNum column, or raises an exception if the index is not found.
        /// </summary>
        private ITableIndex GetParentObjIndex()
        {
            if (configDatabase.ObjTable.TryGetIndex("ParentObjNum", out ITableIndex parentObjIndex))
                return parentObjIndex;
            else
                throw new ScadaException(CommonPhrases.IndexNotFound);
        }

        /// <summary>
        /// Adds objects to the tree view recursively.
        /// </summary>
        private void AddChildObjects(ITableIndex parentObjIndex, int parentObjNum, TreeNode parentNode)
        {
            foreach (Obj childObj in parentObjIndex.SelectItems(parentObjNum))
            {
                if (childObj.ObjNum <= 0)
                    continue; // protect from infinite loop

                TreeNode childNode = TreeViewExtensions.CreateNode(GetNodeText(childObj), "obj.png", childObj);

                if (parentNode == null)
                    tvObj.Nodes.Add(childNode);
                else
                    parentNode.Nodes.Add(childNode);

                AddChildObjects(parentObjIndex, childObj.ObjNum, childNode);
            }
        }

        /// <summary>
        /// Shows the properties of the selected object.
        /// </summary>
        private void ShowObjectProperties()
        {
            changing = true;

            if (selectedObj == null)
            {
                gbObject.Enabled = false;
                numObjNum.Value = numObjNum.Minimum;
                txtName.Text = "";
                txtCode.Text = "";
                cbParentObj.SelectedIndex = -1;
                txtDescr.Text = "";
            }
            else
            {
                gbObject.Enabled = true;
                numObjNum.SetValue(selectedObj.ObjNum);
                txtName.Text = selectedObj.Name;
                txtCode.Text = selectedObj.Code;
                cbParentObj.SelectedValue = selectedObj.ParentObjNum ?? 0;
                txtDescr.Text = selectedObj.Descr;
            }

            changing = false;
        }

        /// <summary>
        /// Sets the data change flag.
        /// </summary>
        private void MarkDataAsModified()
        {
            configDatabase.ObjTable.Modified = true;
            ChildFormTag.Modified = true;
        }

        /// <summary>
        /// Gets the text for an object tree node.
        /// </summary>
        private static string GetNodeText(Obj obj)
        {
            return string.Format(CommonPhrases.EntityCaption, obj.ObjNum, obj.Name);
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void Save()
        {
            if (configDatabase.SaveTable(configDatabase.ObjTable, out string errMsg))
                ChildFormTag.Modified = false;
            else
                adminContext.ErrLog.HandleError(errMsg);
        }


        private void FrmObjectEditor_Load(object sender, EventArgs e)
        {
            FormTranslator.Translate(this, GetType().FullName, new FormTranslatorOptions { ContextMenus = [cmsTree] });
            AddTreeViewImages();
            ShowData();
        }

        private void FrmObjectEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }

        private void FrmObjectEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        e.Handled = true;
                        break;
                }
            }
        }


        private void btnAddObject_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }


        private void numObjNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!changing && selectedObj != null && selectedNode != null)
            {
                selectedObj.Name = txtName.Text;
                selectedNode.Text = GetNodeText(selectedObj);
                MarkDataAsModified();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (!changing && selectedObj != null)
            {
                selectedObj.Code = txtCode.Text;
                MarkDataAsModified();
            }
        }

        private void cbParentObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changing && selectedObj != null && selectedNode != null)
            {
                int parentObjNum = (int)cbParentObj.SelectedValue;

                // validate parent object
                if (parentObjNum == selectedObj.ObjNum)
                {
                    ScadaUiUtils.ShowError("!!!"); // TODO: phrase
                    cbParentObj.SelectedIndexChanged -= cbParentObj_SelectedIndexChanged;
                    cbParentObj.SelectedValue = selectedObj.ParentObjNum ?? 0;
                    cbParentObj.SelectedIndexChanged += cbParentObj_SelectedIndexChanged;
                    return;
                }

                // update object
                Obj newObj = selectedObj.DeepClone();
                newObj.ParentObjNum = parentObjNum > 0 ? parentObjNum : null;
                configDatabase.ObjTable.AddItem(newObj); // add with index update
                MarkDataAsModified();

                // update tree view
                try
                {
                    tvObj.BeginUpdate();
                    selectedNode.Remove();
                    selectedNode.Tag = newObj;

                    if (parentObjNum > 0)
                    {
                        TreeNode parentNode = tvObj.Nodes.IterateNodes()
                            .Where(node => ((Obj)node.Tag).ObjNum == parentObjNum).FirstOrDefault();
                        
                        if (parentNode != null)
                        {
                            parentNode.Nodes.Clear();
                            AddChildObjects(GetParentObjIndex(), parentObjNum, parentNode);
                        }
                    }
                    else
                    {
                        AddChildObjects(GetParentObjIndex(), 0, null);
                    }
                }
                finally
                {
                    tvObj.EndUpdate();
                }
            }
        }

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {
            if (!changing && selectedObj != null)
            {
                selectedObj.Descr = txtDescr.Text;
                MarkDataAsModified();
            }
        }


        private void tvObj_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = e.Node;
            selectedObj = selectedNode.Tag as Obj;
            btnDeleteObject.Enabled = selectedObj != null;
            ShowObjectProperties();
        }

        private void miCollapseAll_Click(object sender, EventArgs e)
        {
            if (tvObj.Nodes.Count > 0)
            {
                tvObj.SelectedNode = null;
                tvObj.CollapseAll();
                tvObj.SelectedNode = tvObj.Nodes[0];
            }
        }
    }
}