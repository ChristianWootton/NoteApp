namespace NoteCreationApp
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
            this.titleMessage = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.textTitleInput = new System.Windows.Forms.TextBox();
            this.textMessageInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newMessageButton = new System.Windows.Forms.Button();
            this.saveMessageButton = new System.Windows.Forms.Button();
            this.readMessageButton = new System.Windows.Forms.Button();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleMessage
            // 
            this.titleMessage.AutoSize = true;
            this.titleMessage.Location = new System.Drawing.Point(32, 12);
            this.titleMessage.Name = "titleMessage";
            this.titleMessage.Size = new System.Drawing.Size(27, 13);
            this.titleMessage.TabIndex = 0;
            this.titleMessage.Text = "Title";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(9, 38);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message";
            // 
            // textTitleInput
            // 
            this.textTitleInput.Location = new System.Drawing.Point(66, 12);
            this.textTitleInput.Name = "textTitleInput";
            this.textTitleInput.Size = new System.Drawing.Size(100, 20);
            this.textTitleInput.TabIndex = 2;
            // 
            // textMessageInput
            // 
            this.textMessageInput.Location = new System.Drawing.Point(66, 38);
            this.textMessageInput.Multiline = true;
            this.textMessageInput.Name = "textMessageInput";
            this.textMessageInput.Size = new System.Drawing.Size(214, 140);
            this.textMessageInput.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 166);
            this.dataGridView1.TabIndex = 4;
            // 
            // newMessageButton
            // 
            this.newMessageButton.Location = new System.Drawing.Point(66, 184);
            this.newMessageButton.Name = "newMessageButton";
            this.newMessageButton.Size = new System.Drawing.Size(75, 23);
            this.newMessageButton.TabIndex = 5;
            this.newMessageButton.Text = "New";
            this.newMessageButton.UseVisualStyleBackColor = true;
            this.newMessageButton.Click += new System.EventHandler(this.newMessageButton_Click);
            // 
            // saveMessageButton
            // 
            this.saveMessageButton.Location = new System.Drawing.Point(147, 184);
            this.saveMessageButton.Name = "saveMessageButton";
            this.saveMessageButton.Size = new System.Drawing.Size(75, 23);
            this.saveMessageButton.TabIndex = 6;
            this.saveMessageButton.Text = "Save";
            this.saveMessageButton.UseVisualStyleBackColor = true;
            this.saveMessageButton.Click += new System.EventHandler(this.saveMessageButton_Click);
            // 
            // readMessageButton
            // 
            this.readMessageButton.Location = new System.Drawing.Point(331, 184);
            this.readMessageButton.Name = "readMessageButton";
            this.readMessageButton.Size = new System.Drawing.Size(75, 23);
            this.readMessageButton.TabIndex = 7;
            this.readMessageButton.Text = "Read";
            this.readMessageButton.UseVisualStyleBackColor = true;
            this.readMessageButton.Click += new System.EventHandler(this.readMessageButton_Click);
            // 
            // deleteMessageButton
            // 
            this.deleteMessageButton.Location = new System.Drawing.Point(412, 184);
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.Size = new System.Drawing.Size(75, 23);
            this.deleteMessageButton.TabIndex = 8;
            this.deleteMessageButton.Text = "Delete";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            this.deleteMessageButton.Click += new System.EventHandler(this.deleteMessageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 266);
            this.Controls.Add(this.deleteMessageButton);
            this.Controls.Add(this.readMessageButton);
            this.Controls.Add(this.saveMessageButton);
            this.Controls.Add(this.newMessageButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMessageInput);
            this.Controls.Add(this.textTitleInput);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.titleMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleMessage;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox textTitleInput;
        private System.Windows.Forms.TextBox textMessageInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newMessageButton;
        private System.Windows.Forms.Button saveMessageButton;
        private System.Windows.Forms.Button readMessageButton;
        private System.Windows.Forms.Button deleteMessageButton;
    }
}

