﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Forms;
using Scada.Server.Archives;
using System.ComponentModel;

namespace Scada.Server.Forms.Controls
{
    /// <summary>
    /// Represents a control for editing historical archive options.
    /// <para>Представляет элемент управления для редактирования параметров исторического архива.</para>
    /// </summary>
    public partial class CtrlHistoricalArchiveOptions : UserControl
    {
        private HistoricalArchiveOptions options;
        private bool changing;


        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public CtrlHistoricalArchiveOptions()
        {
            InitializeComponent();

            options = null;
            changing = false;
        }


        /// <summary>
        /// Gets or sets the archive options being edited.
        /// </summary>
        [Browsable(false)]
        public HistoricalArchiveOptions ArchiveOptions
        {
            get
            {
                return options;
            }
            set
            {
                options = value;
                OptionsToControls();
                SetEnabled();
            }
        }


        /// <summary>
        /// Sets the Enabled property of the controls.
        /// </summary>
        private void DoSetEnabled()
        {
            if (chkReadOnly.Checked)
            {
                lblRetention.Enabled = numRetention.Enabled = txtRetentionUnit.Enabled =
                    lblIsPeriodic.Enabled = chkIsPeriodic.Enabled =
                    lblWriteWithPeriod.Enabled = chkWriteWithPeriod.Enabled =
                    lblUsePeriodStartTime.Enabled = chkUsePeriodStartTime.Enabled =
                    lblWritingPeriod.Enabled = numWritingPeriod.Enabled = cbWritingPeriodUnit.Enabled =
                    lblWritingOffset.Enabled = numWritingOffset.Enabled = cbWritingOffsetUnit.Enabled =
                    lblPullToPeriod.Enabled = numPullToPeriod.Enabled = txtPullToPeriodUnit.Enabled =
                    lblWriteOnChange.Enabled = chkWriteOnChange.Enabled =
                    lblDeadband.Enabled = numDeadband.Enabled = cbDeadbandUnit.Enabled = false;
            }
            else
            {
                lblRetention.Enabled = numRetention.Enabled = txtRetentionUnit.Enabled =
                    lblIsPeriodic.Enabled = chkIsPeriodic.Enabled =
                    lblWriteWithPeriod.Enabled = chkWriteWithPeriod.Enabled = true;

                // write with period controls
                lblUsePeriodStartTime.Enabled = chkUsePeriodStartTime.Enabled =
                    lblWritingPeriod.Enabled = numWritingPeriod.Enabled = cbWritingPeriodUnit.Enabled =
                    lblWritingOffset.Enabled = numWritingOffset.Enabled = cbWritingOffsetUnit.Enabled =
                    chkIsPeriodic.Checked || chkWriteWithPeriod.Checked;

                lblPullToPeriod.Enabled = numPullToPeriod.Enabled = txtPullToPeriodUnit.Enabled =
                    chkIsPeriodic.Checked;

                // write on change controls
                lblWriteOnChange.Enabled = chkWriteOnChange.Enabled =
                    !chkIsPeriodic.Checked;

                lblDeadband.Enabled = numDeadband.Enabled = cbDeadbandUnit.Enabled =
                    !chkIsPeriodic.Checked && chkWriteOnChange.Checked;
            }
        }

        /// <summary>
        /// Sets the Enabled property of the controls if a change is not in progress.
        /// </summary>
        private void SetEnabled()
        {
            if (!changing)
            {
                changing = true;
                DoSetEnabled();
                changing = false;
            }
        }

        /// <summary>
        /// Sets the controls according to the options.
        /// </summary>
        private void OptionsToControls()
        {
            if (options == null)
            {
                Enabled = false;
                chkReadOnly.Checked = false;
                chkLogEnabled.Checked = false;
                numRetention.Value = 1;
                chkIsPeriodic.Checked = false;
                chkWriteWithPeriod.Checked = false;
                chkUsePeriodStartTime.Checked = false;
                numWritingPeriod.Value = 1;
                cbWritingPeriodUnit.SelectedIndex = 0;
                numWritingOffset.Value = 0;
                cbWritingOffsetUnit.SelectedIndex = 0;
                numPullToPeriod.Value = 0;
                chkWriteOnChange.Checked = false;
                numDeadband.Value = 0;
                cbDeadbandUnit.SelectedIndex = 0;
            }
            else
            {
                Enabled = true;
                chkReadOnly.Checked = options.ReadOnly;
                chkLogEnabled.Checked = options.LogEnabled;
                numRetention.SetValue(options.Retention);
                chkIsPeriodic.Checked = options.IsPeriodic;
                chkWriteWithPeriod.Checked = options.WriteWithPeriod;
                chkUsePeriodStartTime.Checked = options.UsePeriodStartTime;
                numWritingPeriod.SetValue(options.WritingPeriod);
                cbWritingPeriodUnit.SelectedIndex = (int)options.WritingPeriodUnit;
                numWritingOffset.SetValue(options.WritingOffset);
                cbWritingOffsetUnit.SelectedIndex = (int)options.WritingOffsetUnit;
                numPullToPeriod.SetValue(options.PullToPeriod);
                chkWriteOnChange.Checked = options.WriteOnChange;
                numDeadband.SetValue(Convert.ToDecimal(options.Deadband));
                cbDeadbandUnit.SelectedIndex = (int)options.DeadbandUnit;
            }
        }

        /// <summary>
        /// Sets the options according to the controls.
        /// </summary>
        public void ControlsToOptions()
        {
            if (options != null)
            {
                options.ReadOnly = chkReadOnly.Checked;
                options.LogEnabled = chkLogEnabled.Checked;
                options.Retention = Convert.ToInt32(numRetention.Value);
                options.IsPeriodic = chkIsPeriodic.Checked;
                options.WriteWithPeriod = chkWriteWithPeriod.Checked;
                options.UsePeriodStartTime = chkUsePeriodStartTime.Checked;
                options.WritingPeriod = Convert.ToInt32(numWritingPeriod.Value);
                options.WritingPeriodUnit = (TimeUnit)cbWritingPeriodUnit.SelectedIndex;
                options.WritingOffset = Convert.ToInt32(numWritingOffset.Value);
                options.WritingOffsetUnit = (TimeUnit)cbWritingOffsetUnit.SelectedIndex;
                options.PullToPeriod = Convert.ToInt32(numPullToPeriod.Value);
                options.WriteOnChange = chkWriteOnChange.Checked;
                options.Deadband = Convert.ToDouble(numDeadband.Value);
                options.DeadbandUnit = (DeadbandUnit)cbDeadbandUnit.SelectedIndex;
            }
        }


        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabled();
        }

        private void chkIsPeriodic_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabled();
        }

        private void chkWriteWithPeriod_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabled();
        }

        private void chkWriteOnChange_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabled();
        }
    }
}
