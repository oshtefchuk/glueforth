﻿namespace GlueForth.Module.Win {
    partial class BlueNorthWindowsFormsModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // BlueNorthWindowsFormsModule
            // 
            this.RequiredModuleTypes.Add(typeof(GlueForth.Module.BlueNorthModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Notifications.Win.NotificationsWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule));
        }

        #endregion
    }
}