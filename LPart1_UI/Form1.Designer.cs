namespace LPart1_UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputGroupbox = new System.Windows.Forms.GroupBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ShiftTxt = new System.Windows.Forms.Label();
            this.StringTxt = new System.Windows.Forms.Label();
            this.StringInput = new System.Windows.Forms.TextBox();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.EncodedOutput = new System.Windows.Forms.TextBox();
            this.SortedOutput = new System.Windows.Forms.TextBox();
            this.ASCIIOutput = new System.Windows.Forms.TextBox();
            this.ShiftOutput = new System.Windows.Forms.TextBox();
            this.StringOutput = new System.Windows.Forms.TextBox();
            this.ShiftInput = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.InputGroupbox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // InputGroupbox
            // 
            this.InputGroupbox.Controls.Add(this.ShiftInput);
            this.InputGroupbox.Controls.Add(this.PrintBtn);
            this.InputGroupbox.Controls.Add(this.ShiftTxt);
            this.InputGroupbox.Controls.Add(this.StringTxt);
            this.InputGroupbox.Controls.Add(this.StringInput);
            this.InputGroupbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.InputGroupbox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.InputGroupbox.Location = new System.Drawing.Point(13, 32);
            this.InputGroupbox.Name = "InputGroupbox";
            this.InputGroupbox.Size = new System.Drawing.Size(362, 406);
            this.InputGroupbox.TabIndex = 1;
            this.InputGroupbox.TabStop = false;
            this.InputGroupbox.Text = "Input";
            this.InputGroupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.Red;
            this.PrintBtn.Location = new System.Drawing.Point(115, 256);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(125, 47);
            this.PrintBtn.TabIndex = 8;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // ShiftTxt
            // 
            this.ShiftTxt.AutoSize = true;
            this.ShiftTxt.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftTxt.Location = new System.Drawing.Point(27, 184);
            this.ShiftTxt.Name = "ShiftTxt";
            this.ShiftTxt.Size = new System.Drawing.Size(95, 40);
            this.ShiftTxt.TabIndex = 3;
            this.ShiftTxt.Text = "Shift";
            this.ShiftTxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // StringTxt
            // 
            this.StringTxt.AutoSize = true;
            this.StringTxt.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringTxt.Location = new System.Drawing.Point(27, 127);
            this.StringTxt.Name = "StringTxt";
            this.StringTxt.Size = new System.Drawing.Size(118, 40);
            this.StringTxt.TabIndex = 1;
            this.StringTxt.Text = "String";
            this.StringTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // StringInput
            // 
            this.StringInput.ForeColor = System.Drawing.Color.DimGray;
            this.StringInput.Location = new System.Drawing.Point(187, 136);
            this.StringInput.Name = "StringInput";
            this.StringInput.Size = new System.Drawing.Size(136, 28);
            this.StringInput.TabIndex = 0;
            this.StringInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.EncodedOutput);
            this.OutputGroupBox.Controls.Add(this.SortedOutput);
            this.OutputGroupBox.Controls.Add(this.ASCIIOutput);
            this.OutputGroupBox.Controls.Add(this.ShiftOutput);
            this.OutputGroupBox.Controls.Add(this.StringOutput);
            this.OutputGroupBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.OutputGroupBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.OutputGroupBox.Location = new System.Drawing.Point(417, 32);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(362, 406);
            this.OutputGroupBox.TabIndex = 2;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            this.OutputGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // EncodedOutput
            // 
            this.EncodedOutput.ForeColor = System.Drawing.Color.DimGray;
            this.EncodedOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EncodedOutput.Location = new System.Drawing.Point(52, 284);
            this.EncodedOutput.Name = "EncodedOutput";
            this.EncodedOutput.ReadOnly = true;
            this.EncodedOutput.Size = new System.Drawing.Size(267, 28);
            this.EncodedOutput.TabIndex = 16;
            this.EncodedOutput.Text = "Encoded Result";
            this.EncodedOutput.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // SortedOutput
            // 
            this.SortedOutput.ForeColor = System.Drawing.Color.DimGray;
            this.SortedOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SortedOutput.Location = new System.Drawing.Point(52, 224);
            this.SortedOutput.Name = "SortedOutput";
            this.SortedOutput.ReadOnly = true;
            this.SortedOutput.Size = new System.Drawing.Size(267, 28);
            this.SortedOutput.TabIndex = 14;
            this.SortedOutput.Text = "Sorted Result";
            // 
            // ASCIIOutput
            // 
            this.ASCIIOutput.ForeColor = System.Drawing.Color.DimGray;
            this.ASCIIOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ASCIIOutput.Location = new System.Drawing.Point(52, 162);
            this.ASCIIOutput.Name = "ASCIIOutput";
            this.ASCIIOutput.ReadOnly = true;
            this.ASCIIOutput.Size = new System.Drawing.Size(267, 28);
            this.ASCIIOutput.TabIndex = 12;
            this.ASCIIOutput.Text = "ASCII Result";
            this.ASCIIOutput.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ShiftOutput
            // 
            this.ShiftOutput.ForeColor = System.Drawing.Color.DimGray;
            this.ShiftOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShiftOutput.Location = new System.Drawing.Point(52, 102);
            this.ShiftOutput.Name = "ShiftOutput";
            this.ShiftOutput.ReadOnly = true;
            this.ShiftOutput.Size = new System.Drawing.Size(267, 28);
            this.ShiftOutput.TabIndex = 10;
            this.ShiftOutput.Text = "Shift Result";
            this.ShiftOutput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // StringOutput
            // 
            this.StringOutput.ForeColor = System.Drawing.Color.DimGray;
            this.StringOutput.Location = new System.Drawing.Point(52, 45);
            this.StringOutput.Name = "StringOutput";
            this.StringOutput.ReadOnly = true;
            this.StringOutput.Size = new System.Drawing.Size(267, 28);
            this.StringOutput.TabIndex = 8;
            this.StringOutput.Text = "String Result";
            this.StringOutput.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ShiftInput
            // 
            this.ShiftInput.Location = new System.Drawing.Point(187, 191);
            this.ShiftInput.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ShiftInput.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.ShiftInput.Name = "ShiftInput";
            this.ShiftInput.Size = new System.Drawing.Size(136, 28);
            this.ShiftInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.InputGroupbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ConsoleApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InputGroupbox.ResumeLayout(false);
            this.InputGroupbox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.GroupBox InputGroupbox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Label ShiftTxt;
        private System.Windows.Forms.Label StringTxt;
        private System.Windows.Forms.TextBox StringInput;
        private System.Windows.Forms.TextBox ShiftOutput;
        private System.Windows.Forms.TextBox StringOutput;
        private System.Windows.Forms.TextBox ASCIIOutput;
        private System.Windows.Forms.TextBox EncodedOutput;
        private System.Windows.Forms.TextBox SortedOutput;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown ShiftInput;
    }
}

