
namespace CheeseMakingApp
{
    partial class LoginForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonAccountant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxLogin.Location = new System.Drawing.Point(164, 133);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(152, 30);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(164, 183);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(152, 30);
            this.textBoxPassword.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.welcomeLabel.Location = new System.Drawing.Point(150, 39);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(168, 39);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(164, 250);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(152, 42);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Location = new System.Drawing.Point(313, 39);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(57, 39);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWorker.FlatAppearance.BorderSize = 0;
            this.buttonWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorker.Location = new System.Drawing.Point(87, 39);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(57, 39);
            this.buttonWorker.TabIndex = 3;
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // buttonAccountant
            // 
            this.buttonAccountant.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccountant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccountant.FlatAppearance.BorderSize = 0;
            this.buttonAccountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountant.Location = new System.Drawing.Point(205, 81);
            this.buttonAccountant.Name = "buttonAccountant";
            this.buttonAccountant.Size = new System.Drawing.Size(57, 39);
            this.buttonAccountant.TabIndex = 3;
            this.buttonAccountant.UseVisualStyleBackColor = false;
            this.buttonAccountant.Click += new System.EventHandler(this.buttonAccountant_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.buttonAccountant);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonWorker;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAccountant;
    }
}