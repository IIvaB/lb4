namespace lb4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tringle = new PictureBox();
            start = new Button();
            about = new Button();
            exit = new Button();
            main = new Label();
            a = new Label();
            c = new Label();
            b = new Label();
            aIn = new TextBox();
            cIn = new TextBox();
            bIn = new TextBox();
            resultText = new Label();
            result = new TextBox();
            resultStorona = new TextBox();
            resultSize = new TextBox();
            Rovno = new Label();
            ((System.ComponentModel.ISupportInitialize)Tringle).BeginInit();
            SuspendLayout();
            // 
            // Tringle
            // 
            Tringle.Location = new Point(38, 72);
            Tringle.Name = "Tringle";
            Tringle.Size = new Size(207, 272);
            Tringle.TabIndex = 0;
            Tringle.TabStop = false;
            Tringle.Click += Tringle_Click;
            // 
            // start
            // 
            start.Location = new Point(456, 348);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 1;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += run_Click;
            // 
            // about
            // 
            about.Location = new Point(284, 396);
            about.Name = "about";
            about.Size = new Size(75, 23);
            about.TabIndex = 2;
            about.Text = "about";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // exit
            // 
            exit.Location = new Point(456, 393);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 3;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // main
            // 
            main.AutoSize = true;
            main.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            main.ForeColor = Color.Blue;
            main.Location = new Point(284, 41);
            main.Name = "main";
            main.Size = new Size(238, 21);
            main.TabIndex = 4;
            main.Text = "Введіть сторони трикутника";
            main.Click += label1_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 20.25F);
            a.ForeColor = Color.Purple;
            a.Location = new Point(284, 89);
            a.Name = "a";
            a.Size = new Size(37, 37);
            a.TabIndex = 5;
            a.Text = "a:";
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 20.25F);
            c.ForeColor = Color.Purple;
            c.Location = new Point(284, 168);
            c.Name = "c";
            c.Size = new Size(35, 37);
            c.TabIndex = 6;
            c.Text = "c:";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 20.25F);
            b.ForeColor = Color.Purple;
            b.Location = new Point(284, 131);
            b.Name = "b";
            b.Size = new Size(39, 37);
            b.TabIndex = 7;
            b.Text = "b:";
            b.Click += label4_Click;
            // 
            // aIn
            // 
            aIn.Location = new Point(345, 103);
            aIn.Name = "aIn";
            aIn.Size = new Size(100, 23);
            aIn.TabIndex = 8;
            aIn.TextChanged += textBox1_TextChanged;
            // 
            // cIn
            // 
            cIn.Location = new Point(345, 182);
            cIn.Name = "cIn";
            cIn.Size = new Size(100, 23);
            cIn.TabIndex = 9;
            // 
            // bIn
            // 
            bIn.Location = new Point(345, 146);
            bIn.Name = "bIn";
            bIn.Size = new Size(100, 23);
            bIn.TabIndex = 10;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultText.ForeColor = Color.Blue;
            resultText.Location = new Point(284, 235);
            resultText.Name = "resultText";
            resultText.Size = new Size(90, 21);
            resultText.TabIndex = 11;
            resultText.Text = "Результат:";
            // 
            // result
            // 
            result.Location = new Point(284, 287);
            result.Name = "result";
            result.Size = new Size(247, 23);
            result.TabIndex = 12;
            // 
            // resultStorona
            // 
            resultStorona.Location = new Point(284, 347);
            resultStorona.Name = "resultStorona";
            resultStorona.Size = new Size(75, 23);
            resultStorona.TabIndex = 13;
            // 
            // resultSize
            // 
            resultSize.Location = new Point(401, 347);
            resultSize.Name = "resultSize";
            resultSize.Size = new Size(22, 23);
            resultSize.TabIndex = 14;
            // 
            // Rovno
            // 
            Rovno.AutoSize = true;
            Rovno.Location = new Point(371, 349);
            Rovno.Name = "Rovno";
            Rovno.Size = new Size(15, 15);
            Rovno.TabIndex = 15;
            Rovno.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(Rovno);
            Controls.Add(resultSize);
            Controls.Add(resultStorona);
            Controls.Add(result);
            Controls.Add(resultText);
            Controls.Add(bIn);
            Controls.Add(cIn);
            Controls.Add(aIn);
            Controls.Add(b);
            Controls.Add(c);
            Controls.Add(a);
            Controls.Add(main);
            Controls.Add(exit);
            Controls.Add(about);
            Controls.Add(start);
            Controls.Add(Tringle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Tringle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Tringle;
        private Button start;
        private Button about;
        private Button exit;
        private Label main;
        private Label a;
        private Label c;
        private Label b;
        private TextBox aIn;
        private TextBox cIn;
        private TextBox bIn;
        private Label resultText;
        private TextBox result;
        private TextBox resultStorona;
        private TextBox resultSize;
        private Label Rovno;
    }
}
