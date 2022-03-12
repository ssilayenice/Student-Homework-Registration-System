using System;
using System.Windows.Forms;

namespace School
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pageTeacher = new DevExpress.XtraTab.XtraTabPage();
            this.dateCompositionTime = new DevExpress.XtraEditors.DateEdit();
            this.txtStudentGrade = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentAge = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblHwTeacher = new DevExpress.XtraEditors.LabelControl();
            this.treeListTeacher = new DevExpress.XtraTreeList.TreeList();
            this.clmnDateT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnSNameT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnStudentGradeT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnSituationT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnTopicT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnUnitT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnCompletionTimeT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnTeacherOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblTopic = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtTopic = new DevExpress.XtraEditors.TextEdit();
            this.pageStudent = new DevExpress.XtraTab.XtraTabPage();
            this.treeListStudent = new DevExpress.XtraTreeList.TreeList();
            this.tlColIsSelected = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SelectedCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clmnDateS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnStudentNameS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListAge = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnStudentGradeS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnSituationS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnTopicS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnUnitS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clmnCompletionTimeS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lblHwStudent = new DevExpress.XtraEditors.LabelControl();
            this.tbControl = new DevExpress.XtraTab.XtraTabControl();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pageTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompositionTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompositionTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopic.Properties)).BeginInit();
            this.pageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "CreateTime";
            this.treeListColumn2.FieldName = "CreateTime";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 77;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "CreateTime";
            this.treeListColumn3.FieldName = "CreateTime";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 77;
            // 
            // pageTeacher
            // 
            this.pageTeacher.Controls.Add(this.dateCompositionTime);
            this.pageTeacher.Controls.Add(this.txtStudentGrade);
            this.pageTeacher.Controls.Add(this.txtStudentAge);
            this.pageTeacher.Controls.Add(this.txtStudentName);
            this.pageTeacher.Controls.Add(this.labelControl5);
            this.pageTeacher.Controls.Add(this.labelControl4);
            this.pageTeacher.Controls.Add(this.labelControl3);
            this.pageTeacher.Controls.Add(this.labelControl2);
            this.pageTeacher.Controls.Add(this.labelControl1);
            this.pageTeacher.Controls.Add(this.lblHwTeacher);
            this.pageTeacher.Controls.Add(this.treeListTeacher);
            this.pageTeacher.Controls.Add(this.btnTeacherOk);
            this.pageTeacher.Controls.Add(this.lblUnit);
            this.pageTeacher.Controls.Add(this.lblTime);
            this.pageTeacher.Controls.Add(this.lblTopic);
            this.pageTeacher.Controls.Add(this.txtUnit);
            this.pageTeacher.Controls.Add(this.txtTopic);
            this.pageTeacher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageTeacher.ImageOptions.Image")));
            this.pageTeacher.Name = "pageTeacher";
            this.pageTeacher.Size = new System.Drawing.Size(883, 445);
            this.pageTeacher.Text = "Teacher";
            // 
            // dateCompositionTime
            // 
            this.dateCompositionTime.EditValue = null;
            this.dateCompositionTime.Location = new System.Drawing.Point(96, 75);
            this.dateCompositionTime.Name = "dateCompositionTime";
            this.dateCompositionTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCompositionTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCompositionTime.Size = new System.Drawing.Size(154, 20);
            this.dateCompositionTime.TabIndex = 17;
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(413, 107);
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.Size = new System.Drawing.Size(100, 20);
            this.txtStudentGrade.TabIndex = 16;
            this.txtStudentGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentGrade_KeyPress);
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(413, 71);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(100, 20);
            this.txtStudentAge.TabIndex = 15;
            this.txtStudentAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentAge_KeyPress);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(413, 39);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(328, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Student Grade :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(328, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Student Age :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(328, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Student Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(349, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 22);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Student Information";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(193, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Homework Information";
            // 
            // lblHwTeacher
            // 
            this.lblHwTeacher.Location = new System.Drawing.Point(651, 363);
            this.lblHwTeacher.Name = "lblHwTeacher";
            this.lblHwTeacher.Size = new System.Drawing.Size(0, 13);
            this.lblHwTeacher.TabIndex = 8;
            // 
            // treeListTeacher
            // 
            this.treeListTeacher.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.clmnDateT,
            this.clmnSNameT,
            this.treeListColumn1,
            this.clmnStudentGradeT,
            this.clmnSituationT,
            this.clmnTopicT,
            this.clmnUnitT,
            this.clmnCompletionTimeT});
            this.treeListTeacher.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.treeListTeacher.Location = new System.Drawing.Point(3, 193);
            this.treeListTeacher.Name = "treeListTeacher";
            this.treeListTeacher.Size = new System.Drawing.Size(866, 100);
            this.treeListTeacher.TabIndex = 7;
            // 
            // clmnDateT
            // 
            this.clmnDateT.Caption = "Date";
            this.clmnDateT.FieldName = "Homework.CreateTime";
            this.clmnDateT.Name = "clmnDateT";
            this.clmnDateT.Visible = true;
            this.clmnDateT.VisibleIndex = 0;
            this.clmnDateT.Width = 77;
            // 
            // clmnSNameT
            // 
            this.clmnSNameT.Caption = "Student Name";
            this.clmnSNameT.FieldName = "Name";
            this.clmnSNameT.Name = "clmnSNameT";
            this.clmnSNameT.Visible = true;
            this.clmnSNameT.VisibleIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Student Age";
            this.treeListColumn1.FieldName = "Age";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 2;
            // 
            // clmnStudentGradeT
            // 
            this.clmnStudentGradeT.Caption = "Student Grade";
            this.clmnStudentGradeT.FieldName = "Grade";
            this.clmnStudentGradeT.Name = "clmnStudentGradeT";
            this.clmnStudentGradeT.Visible = true;
            this.clmnStudentGradeT.VisibleIndex = 3;
            // 
            // clmnSituationT
            // 
            this.clmnSituationT.Caption = "Homework Situation";
            this.clmnSituationT.FieldName = "Homework.HwSituationType";
            this.clmnSituationT.Name = "clmnSituationT";
            this.clmnSituationT.Visible = true;
            this.clmnSituationT.VisibleIndex = 4;
            this.clmnSituationT.Width = 77;
            // 
            // clmnTopicT
            // 
            this.clmnTopicT.Caption = "Topic";
            this.clmnTopicT.FieldName = "Homework.Topic";
            this.clmnTopicT.Name = "clmnTopicT";
            this.clmnTopicT.Visible = true;
            this.clmnTopicT.VisibleIndex = 5;
            this.clmnTopicT.Width = 76;
            // 
            // clmnUnitT
            // 
            this.clmnUnitT.Caption = "Unit";
            this.clmnUnitT.FieldName = "Homework.Unit";
            this.clmnUnitT.Name = "clmnUnitT";
            this.clmnUnitT.Visible = true;
            this.clmnUnitT.VisibleIndex = 6;
            this.clmnUnitT.Width = 55;
            // 
            // clmnCompletionTimeT
            // 
            this.clmnCompletionTimeT.Caption = "Completion Time";
            this.clmnCompletionTimeT.FieldName = "Homework.CompletionTime";
            this.clmnCompletionTimeT.Name = "clmnCompletionTimeT";
            this.clmnCompletionTimeT.Visible = true;
            this.clmnCompletionTimeT.VisibleIndex = 7;
            this.clmnCompletionTimeT.Width = 97;
            // 
            // btnTeacherOk
            // 
            this.btnTeacherOk.Location = new System.Drawing.Point(576, 114);
            this.btnTeacherOk.Name = "btnTeacherOk";
            this.btnTeacherOk.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherOk.TabIndex = 6;
            this.btnTeacherOk.Text = "OK";
            this.btnTeacherOk.Click += new System.EventHandler(this.btnTeacherOk_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(3, 114);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unit :";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(3, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Compotiton Time :";
            // 
            // lblTopic
            // 
            this.lblTopic.Location = new System.Drawing.Point(3, 42);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(32, 13);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Topic :";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(96, 111);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUnit.Size = new System.Drawing.Size(154, 20);
            this.txtUnit.TabIndex = 2;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(96, 39);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(154, 20);
            this.txtTopic.TabIndex = 0;
            // 
            // pageStudent
            // 
            this.pageStudent.Controls.Add(this.treeListStudent);
            this.pageStudent.Controls.Add(this.lblHwStudent);
            this.pageStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageStudent.ImageOptions.Image")));
            this.pageStudent.Name = "pageStudent";
            this.pageStudent.Size = new System.Drawing.Size(883, 445);
            this.pageStudent.Text = "Student";
            // 
            // treeListStudent
            // 
            this.treeListStudent.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlColIsSelected,
            this.clmnDateS,
            this.clmnStudentNameS,
            this.treeListAge,
            this.clmnStudentGradeS,
            this.clmnSituationS,
            this.clmnTopicS,
            this.clmnUnitS,
            this.clmnCompletionTimeS});
            this.treeListStudent.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.treeListStudent.Location = new System.Drawing.Point(3, 32);
            this.treeListStudent.Name = "treeListStudent";
            this.treeListStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SelectedCheckEdit,
            this.repositoryItemCheckEdit2});
            this.treeListStudent.Size = new System.Drawing.Size(877, 234);
            this.treeListStudent.TabIndex = 8;
            // 
            // tlColIsSelected
            // 
            this.tlColIsSelected.Caption = " ";
            this.tlColIsSelected.ColumnEdit = this.SelectedCheckEdit;
            this.tlColIsSelected.FieldName = "IsSelected";
            this.tlColIsSelected.Name = "tlColIsSelected";
            this.tlColIsSelected.Visible = true;
            this.tlColIsSelected.VisibleIndex = 0;
            this.tlColIsSelected.Width = 20;
            // 
            // SelectedCheckEdit
            // 
            this.SelectedCheckEdit.AutoHeight = false;
            this.SelectedCheckEdit.Caption = "";
            this.SelectedCheckEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.SelectedCheckEdit.Name = "SelectedCheckEdit";
            this.SelectedCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.SelectedCheckEdit.RadioGroupIndex = 0;
            this.SelectedCheckEdit.CheckedChanged += new System.EventHandler(this.SelectedCheckEdit_CheckedChanged);
            // 
            // clmnDateS
            // 
            this.clmnDateS.Caption = "Date";
            this.clmnDateS.FieldName = "Homework.CreateTime";
            this.clmnDateS.Name = "clmnDateS";
            this.clmnDateS.Visible = true;
            this.clmnDateS.VisibleIndex = 1;
            this.clmnDateS.Width = 94;
            // 
            // clmnStudentNameS
            // 
            this.clmnStudentNameS.Caption = "Student Name";
            this.clmnStudentNameS.FieldName = "Name";
            this.clmnStudentNameS.Name = "clmnStudentNameS";
            this.clmnStudentNameS.Visible = true;
            this.clmnStudentNameS.VisibleIndex = 2;
            this.clmnStudentNameS.Width = 92;
            // 
            // treeListAge
            // 
            this.treeListAge.Caption = "Student Age";
            this.treeListAge.FieldName = "Age";
            this.treeListAge.Name = "treeListAge";
            this.treeListAge.Visible = true;
            this.treeListAge.VisibleIndex = 3;
            this.treeListAge.Width = 93;
            // 
            // clmnStudentGradeS
            // 
            this.clmnStudentGradeS.Caption = "Student Grade";
            this.clmnStudentGradeS.FieldName = "Grade";
            this.clmnStudentGradeS.Name = "clmnStudentGradeS";
            this.clmnStudentGradeS.Visible = true;
            this.clmnStudentGradeS.VisibleIndex = 4;
            this.clmnStudentGradeS.Width = 92;
            // 
            // clmnSituationS
            // 
            this.clmnSituationS.Caption = "Homework Situation";
            this.clmnSituationS.FieldName = "Homework.HwSituationType";
            this.clmnSituationS.Name = "clmnSituationS";
            this.clmnSituationS.Visible = true;
            this.clmnSituationS.VisibleIndex = 5;
            this.clmnSituationS.Width = 95;
            // 
            // clmnTopicS
            // 
            this.clmnTopicS.Caption = "Topic";
            this.clmnTopicS.FieldName = "Homework.Topic";
            this.clmnTopicS.Name = "clmnTopicS";
            this.clmnTopicS.Visible = true;
            this.clmnTopicS.VisibleIndex = 6;
            this.clmnTopicS.Width = 93;
            // 
            // clmnUnitS
            // 
            this.clmnUnitS.Caption = "Unit";
            this.clmnUnitS.FieldName = "Homework.Unit";
            this.clmnUnitS.Name = "clmnUnitS";
            this.clmnUnitS.Visible = true;
            this.clmnUnitS.VisibleIndex = 7;
            this.clmnUnitS.Width = 72;
            // 
            // clmnCompletionTimeS
            // 
            this.clmnCompletionTimeS.Caption = "Completion Time";
            this.clmnCompletionTimeS.FieldName = "Homework.CompletionTime";
            this.clmnCompletionTimeS.Name = "clmnCompletionTimeS";
            this.clmnCompletionTimeS.Visible = true;
            this.clmnCompletionTimeS.VisibleIndex = 8;
            this.clmnCompletionTimeS.Width = 114;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // lblHwStudent
            // 
            this.lblHwStudent.Location = new System.Drawing.Point(653, 363);
            this.lblHwStudent.Name = "lblHwStudent";
            this.lblHwStudent.Size = new System.Drawing.Size(0, 13);
            this.lblHwStudent.TabIndex = 1;
            // 
            // tbControl
            // 
            this.tbControl.Location = new System.Drawing.Point(12, 3);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedTabPage = this.pageTeacher;
            this.tbControl.Size = new System.Drawing.Size(889, 492);
            this.tbControl.TabIndex = 0;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageStudent,
            this.pageTeacher});
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Homework Situation";
            this.treeListColumn4.FieldName = "HwSituationType";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 5;
            this.treeListColumn4.Width = 95;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Homework Situation";
            this.treeListColumn5.FieldName = "HwSituationType";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 5;
            this.treeListColumn5.Width = 95;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Homework Situation";
            this.treeListColumn6.FieldName = "HwSituationType";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 5;
            this.treeListColumn6.Width = 95;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 496);
            this.Controls.Add(this.tbControl);
            this.Name = "MainForm";
            this.Text = "School";
            this.pageTeacher.ResumeLayout(false);
            this.pageTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompositionTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompositionTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopic.Properties)).EndInit();
            this.pageStudent.ResumeLayout(false);
            this.pageStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTab.XtraTabPage pageTeacher;
        private DevExpress.XtraEditors.DateEdit dateCompositionTime;
        private DevExpress.XtraEditors.TextEdit txtStudentGrade;
        private DevExpress.XtraEditors.TextEdit txtStudentAge;
        private DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblHwTeacher;
        private DevExpress.XtraTreeList.TreeList treeListTeacher;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnDateT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnSNameT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnStudentGradeT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnSituationT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnTopicT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnUnitT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnCompletionTimeT;
        private DevExpress.XtraEditors.SimpleButton btnTeacherOk;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl lblTopic;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.TextEdit txtTopic;
        private DevExpress.XtraTab.XtraTabPage pageStudent;
        private DevExpress.XtraTreeList.TreeList treeListStudent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlColIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit SelectedCheckEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnDateS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnStudentNameS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListAge;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnStudentGradeS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnSituationS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnTopicS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnUnitS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clmnCompletionTimeS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.LabelControl lblHwStudent;
        private DevExpress.XtraTab.XtraTabControl tbControl;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

