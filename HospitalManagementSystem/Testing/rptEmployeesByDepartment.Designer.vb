<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptEmployeesByDepartment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbHospitalDataSet1 = New HospitalManagementSystem.dbHospitalDataSet1()
        Me.EMPLOYEESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEESTableAdapter = New HospitalManagementSystem.dbHospitalDataSet1TableAdapters.EMPLOYEESTableAdapter()
        CType(Me.dbHospitalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EMPLOYEESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HospitalManagementSystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(651, 455)
        Me.ReportViewer1.TabIndex = 1
        '
        'dbHospitalDataSet1
        '
        Me.dbHospitalDataSet1.DataSetName = "dbHospitalDataSet1"
        Me.dbHospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEESBindingSource
        '
        Me.EMPLOYEESBindingSource.DataMember = "EMPLOYEES"
        Me.EMPLOYEESBindingSource.DataSource = Me.dbHospitalDataSet1
        '
        'EMPLOYEESTableAdapter
        '
        Me.EMPLOYEESTableAdapter.ClearBeforeFill = True
        '
        'rptEmployeesByDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 455)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptEmployeesByDepartment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog2"
        CType(Me.dbHospitalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EMPLOYEESBindingSource As BindingSource
    Friend WithEvents dbHospitalDataSet1 As dbHospitalDataSet1
    Friend WithEvents EMPLOYEESTableAdapter As dbHospitalDataSet1TableAdapters.EMPLOYEESTableAdapter
End Class
