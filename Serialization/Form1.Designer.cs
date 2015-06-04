namespace Serialization
{
    partial class Form1
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
            this.serializeBinary = new System.Windows.Forms.Button();
            this.serializeXML = new System.Windows.Forms.Button();
            this.readBinary = new System.Windows.Forms.Button();
            this.readXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopLocation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.routeNum = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.stopTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serializeBinary
            // 
            this.serializeBinary.Location = new System.Drawing.Point(13, 13);
            this.serializeBinary.Name = "serializeBinary";
            this.serializeBinary.Size = new System.Drawing.Size(105, 23);
            this.serializeBinary.TabIndex = 0;
            this.serializeBinary.Text = "Serialize as binary";
            this.serializeBinary.UseVisualStyleBackColor = true;
            this.serializeBinary.Click += new System.EventHandler(this.serializeBinary_Click);
            // 
            // serializeXML
            // 
            this.serializeXML.Location = new System.Drawing.Point(13, 42);
            this.serializeXML.Name = "serializeXML";
            this.serializeXML.Size = new System.Drawing.Size(105, 23);
            this.serializeXML.TabIndex = 1;
            this.serializeXML.Text = "Serialize as XML";
            this.serializeXML.UseVisualStyleBackColor = true;
            this.serializeXML.Click += new System.EventHandler(this.serializeXML_Click);
            // 
            // readBinary
            // 
            this.readBinary.Location = new System.Drawing.Point(194, 12);
            this.readBinary.Name = "readBinary";
            this.readBinary.Size = new System.Drawing.Size(105, 23);
            this.readBinary.TabIndex = 2;
            this.readBinary.Text = "Read as binary";
            this.readBinary.UseVisualStyleBackColor = true;
            this.readBinary.Click += new System.EventHandler(this.readBinary_Click);
            // 
            // readXML
            // 
            this.readXML.Location = new System.Drawing.Point(194, 41);
            this.readXML.Name = "readXML";
            this.readXML.Size = new System.Drawing.Size(105, 23);
            this.readXML.TabIndex = 3;
            this.readXML.Text = "Read as XML";
            this.readXML.UseVisualStyleBackColor = true;
            this.readXML.Click += new System.EventHandler(this.readXML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.routeNum);
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BusRoute";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopTime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.stopLocation);
            this.groupBox3.Location = new System.Drawing.Point(9, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 75);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // stopLocation
            // 
            this.stopLocation.Location = new System.Drawing.Point(60, 19);
            this.stopLocation.Name = "stopLocation";
            this.stopLocation.Size = new System.Drawing.Size(200, 20);
            this.stopLocation.TabIndex = 7;
            this.stopLocation.TextChanged += new System.EventHandler(this.stopLocation_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.startLocation);
            this.groupBox2.Location = new System.Drawing.Point(9, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // startLocation
            // 
            this.startLocation.Location = new System.Drawing.Point(60, 19);
            this.startLocation.Name = "startLocation";
            this.startLocation.Size = new System.Drawing.Size(200, 20);
            this.startLocation.TabIndex = 7;
            this.startLocation.TextChanged += new System.EventHandler(this.startLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Route #";
            // 
            // routeNum
            // 
            this.routeNum.Location = new System.Drawing.Point(59, 19);
            this.routeNum.Name = "routeNum";
            this.routeNum.Size = new System.Drawing.Size(80, 20);
            this.routeNum.TabIndex = 4;
            this.routeNum.TextChanged += new System.EventHandler(this.routeNum_TextChanged);
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(60, 45);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 11;
            this.startTime.ValueChanged += new System.EventHandler(this.startTime_ValueChanged);
            // 
            // stopTime
            // 
            this.stopTime.Location = new System.Drawing.Point(60, 45);
            this.stopTime.Name = "stopTime";
            this.stopTime.Size = new System.Drawing.Size(200, 20);
            this.stopTime.TabIndex = 12;
            this.stopTime.ValueChanged += new System.EventHandler(this.stopTime_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.readXML);
            this.Controls.Add(this.readBinary);
            this.Controls.Add(this.serializeXML);
            this.Controls.Add(this.serializeBinary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serializeBinary;
        private System.Windows.Forms.Button serializeXML;
        private System.Windows.Forms.Button readBinary;
        private System.Windows.Forms.Button readXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox routeNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startLocation;
        private System.Windows.Forms.DateTimePicker stopTime;
        private System.Windows.Forms.DateTimePicker startTime;
    }
}

