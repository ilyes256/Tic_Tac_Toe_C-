namespace Tic_Tac_Toe_C_
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
            this.label1 = new System.Windows.Forms.Label();
            this.pb_00 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_10 = new System.Windows.Forms.PictureBox();
            this.pb_11 = new System.Windows.Forms.PictureBox();
            this.pb_12 = new System.Windows.Forms.PictureBox();
            this.pb_20 = new System.Windows.Forms.PictureBox();
            this.pb_21 = new System.Windows.Forms.PictureBox();
            this.pb_22 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_turn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.btn_restart_game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_22)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(475, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pb_00
            // 
            this.pb_00.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_00.Location = new System.Drawing.Point(420, 103);
            this.pb_00.Name = "pb_00";
            this.pb_00.Size = new System.Drawing.Size(100, 73);
            this.pb_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_00.TabIndex = 1;
            this.pb_00.TabStop = false;
            this.pb_00.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_02
            // 
            this.pb_02.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_02.Location = new System.Drawing.Point(688, 103);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(100, 73);
            this.pb_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_02.TabIndex = 2;
            this.pb_02.TabStop = false;
            this.pb_02.Click += new System.EventHandler(this.pb_02_Click);
            // 
            // pb_01
            // 
            this.pb_01.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_01.Location = new System.Drawing.Point(556, 103);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(100, 73);
            this.pb_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_01.TabIndex = 3;
            this.pb_01.TabStop = false;
            this.pb_01.Click += new System.EventHandler(this.pb_01_Click);
            // 
            // pb_10
            // 
            this.pb_10.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_10.Location = new System.Drawing.Point(420, 202);
            this.pb_10.Name = "pb_10";
            this.pb_10.Size = new System.Drawing.Size(100, 73);
            this.pb_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_10.TabIndex = 4;
            this.pb_10.TabStop = false;
            this.pb_10.Click += new System.EventHandler(this.pb_10_Click);
            // 
            // pb_11
            // 
            this.pb_11.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_11.Location = new System.Drawing.Point(556, 202);
            this.pb_11.Name = "pb_11";
            this.pb_11.Size = new System.Drawing.Size(100, 73);
            this.pb_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_11.TabIndex = 5;
            this.pb_11.TabStop = false;
            this.pb_11.Click += new System.EventHandler(this.pb_11_Click);
            // 
            // pb_12
            // 
            this.pb_12.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_12.Location = new System.Drawing.Point(688, 202);
            this.pb_12.Name = "pb_12";
            this.pb_12.Size = new System.Drawing.Size(100, 73);
            this.pb_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_12.TabIndex = 6;
            this.pb_12.TabStop = false;
            this.pb_12.Click += new System.EventHandler(this.pb_12_Click);
            // 
            // pb_20
            // 
            this.pb_20.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_20.Location = new System.Drawing.Point(420, 310);
            this.pb_20.Name = "pb_20";
            this.pb_20.Size = new System.Drawing.Size(100, 73);
            this.pb_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_20.TabIndex = 7;
            this.pb_20.TabStop = false;
            this.pb_20.Click += new System.EventHandler(this.pb_20_Click);
            // 
            // pb_21
            // 
            this.pb_21.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_21.Location = new System.Drawing.Point(556, 310);
            this.pb_21.Name = "pb_21";
            this.pb_21.Size = new System.Drawing.Size(100, 73);
            this.pb_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_21.TabIndex = 8;
            this.pb_21.TabStop = false;
            this.pb_21.Click += new System.EventHandler(this.pb_21_Click);
            // 
            // pb_22
            // 
            this.pb_22.Image = global::Tic_Tac_Toe_C_.Properties.Resources.question_mark_96;
            this.pb_22.Location = new System.Drawing.Point(688, 310);
            this.pb_22.Name = "pb_22";
            this.pb_22.Size = new System.Drawing.Size(100, 73);
            this.pb_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_22.TabIndex = 9;
            this.pb_22.TabStop = false;
            this.pb_22.Click += new System.EventHandler(this.pb_22_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turn";
            // 
            // lbl_turn
            // 
            this.lbl_turn.AutoSize = true;
            this.lbl_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turn.ForeColor = System.Drawing.Color.White;
            this.lbl_turn.Location = new System.Drawing.Point(41, 162);
            this.lbl_turn.Name = "lbl_turn";
            this.lbl_turn.Size = new System.Drawing.Size(113, 31);
            this.lbl_turn.TabIndex = 12;
            this.lbl_turn.Text = "Player1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(41, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Winner";
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.ForeColor = System.Drawing.Color.White;
            this.lbl_winner.Location = new System.Drawing.Point(41, 280);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(164, 31);
            this.lbl_winner.TabIndex = 14;
            this.lbl_winner.Text = "In Progress";
            this.lbl_winner.Click += new System.EventHandler(this.lbl_winner_Click);
            // 
            // btn_restart_game
            // 
            this.btn_restart_game.BackColor = System.Drawing.Color.Black;
            this.btn_restart_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart_game.ForeColor = System.Drawing.Color.Transparent;
            this.btn_restart_game.Location = new System.Drawing.Point(47, 347);
            this.btn_restart_game.Name = "btn_restart_game";
            this.btn_restart_game.Size = new System.Drawing.Size(230, 72);
            this.btn_restart_game.TabIndex = 16;
            this.btn_restart_game.Text = "Restart Game";
            this.btn_restart_game.UseVisualStyleBackColor = false;
            this.btn_restart_game.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_restart_game);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_turn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_22);
            this.Controls.Add(this.pb_21);
            this.Controls.Add(this.pb_20);
            this.Controls.Add(this.pb_12);
            this.Controls.Add(this.pb_11);
            this.Controls.Add(this.pb_10);
            this.Controls.Add(this.pb_01);
            this.Controls.Add(this.pb_02);
            this.Controls.Add(this.pb_00);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_00;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pb_10;
        private System.Windows.Forms.PictureBox pb_11;
        private System.Windows.Forms.PictureBox pb_12;
        private System.Windows.Forms.PictureBox pb_20;
        private System.Windows.Forms.PictureBox pb_21;
        private System.Windows.Forms.PictureBox pb_22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_turn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Button btn_restart_game;
    }
}

