namespace BDlab1
{
    partial class mainForm
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
            this.TablichiBD = new System.Windows.Forms.ToolStripMenuItem();
            this.Table1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Table2 = new System.Windows.Forms.ToolStripMenuItem();
            this.адмніструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькулятор1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькулятор2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиПарольКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиТипДоступуКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервнеКопіюванняБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервнеВідновленняБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablichiBD,
            this.адмніструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(779, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablichiBD
            // 
            this.TablichiBD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Table1,
            this.Table2});
            this.TablichiBD.Name = "TablichiBD";
            this.TablichiBD.Size = new System.Drawing.Size(108, 27);
            this.TablichiBD.Text = "таблиці БД";
            // 
            // Table1
            // 
            this.Table1.Name = "Table1";
            this.Table1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.Table1.Size = new System.Drawing.Size(242, 28);
            this.Table1.Text = "alergologia";
            this.Table1.Click += new System.EventHandler(this.Table1_Click);
            // 
            // Table2
            // 
            this.Table2.Name = "Table2";
            this.Table2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.Table2.Size = new System.Drawing.Size(242, 28);
            this.Table2.Text = "medicine_aler";
            this.Table2.Click += new System.EventHandler(this.Table2_Click);
            // 
            // адмніструванняToolStripMenuItem
            // 
            this.адмніструванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиКористувачаToolStripMenuItem,
            this.видалитиКористувачаToolStripMenuItem,
            this.змінитиПарольКористувачаToolStripMenuItem,
            this.змінитиТипДоступуКористувачаToolStripMenuItem,
            this.toolStripSeparator1,
            this.резервнеКопіюванняБДToolStripMenuItem,
            this.резервнеВідновленняБДToolStripMenuItem});
            this.адмніструванняToolStripMenuItem.Name = "адмніструванняToolStripMenuItem";
            this.адмніструванняToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.адмніструванняToolStripMenuItem.Text = "Адмністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калькулятор1ToolStripMenuItem,
            this.калькулятор2ToolStripMenuItem});
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            // 
            // калькулятор1ToolStripMenuItem
            // 
            this.калькулятор1ToolStripMenuItem.Name = "калькулятор1ToolStripMenuItem";
            this.калькулятор1ToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.калькулятор1ToolStripMenuItem.Text = "Калькулятор 1";
            this.калькулятор1ToolStripMenuItem.Click += new System.EventHandler(this.калькулятор1ToolStripMenuItem_Click);
            // 
            // калькулятор2ToolStripMenuItem
            // 
            this.калькулятор2ToolStripMenuItem.Name = "калькулятор2ToolStripMenuItem";
            this.калькулятор2ToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.калькулятор2ToolStripMenuItem.Text = "Калькулятор 2";
            this.калькулятор2ToolStripMenuItem.Click += new System.EventHandler(this.калькулятор2ToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(140, 27);
            this.проПрограмуToolStripMenuItem.Text = " Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // додатиКористувачаToolStripMenuItem
            // 
            this.додатиКористувачаToolStripMenuItem.Name = "додатиКористувачаToolStripMenuItem";
            this.додатиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.додатиКористувачаToolStripMenuItem.Text = "Додати користувача";
            this.додатиКористувачаToolStripMenuItem.Click += new System.EventHandler(this.додатиКористувачаToolStripMenuItem_Click);
            // 
            // видалитиКористувачаToolStripMenuItem
            // 
            this.видалитиКористувачаToolStripMenuItem.Name = "видалитиКористувачаToolStripMenuItem";
            this.видалитиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.видалитиКористувачаToolStripMenuItem.Text = "Видалити користувача";
            this.видалитиКористувачаToolStripMenuItem.Click += new System.EventHandler(this.видалитиКористувачаToolStripMenuItem_Click);
            // 
            // змінитиПарольКористувачаToolStripMenuItem
            // 
            this.змінитиПарольКористувачаToolStripMenuItem.Name = "змінитиПарольКористувачаToolStripMenuItem";
            this.змінитиПарольКористувачаToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.змінитиПарольКористувачаToolStripMenuItem.Text = "Змінити пароль користувача";
            this.змінитиПарольКористувачаToolStripMenuItem.Click += new System.EventHandler(this.змінитиПарольКористувачаToolStripMenuItem_Click);
            // 
            // змінитиТипДоступуКористувачаToolStripMenuItem
            // 
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Name = "змінитиТипДоступуКористувачаToolStripMenuItem";
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Text = "Змінити тип доступу користувача";
            this.змінитиТипДоступуКористувачаToolStripMenuItem.Click += new System.EventHandler(this.змінитиТипДоступуКористувачаToolStripMenuItem_Click);
            // 
            // резервнеКопіюванняБДToolStripMenuItem
            // 
            this.резервнеКопіюванняБДToolStripMenuItem.Name = "резервнеКопіюванняБДToolStripMenuItem";
            this.резервнеКопіюванняБДToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.резервнеКопіюванняБДToolStripMenuItem.Text = "Резервне копіювання БД";
            this.резервнеКопіюванняБДToolStripMenuItem.Click += new System.EventHandler(this.резервнеКопіюванняБДToolStripMenuItem_Click);
            // 
            // резервнеВідновленняБДToolStripMenuItem
            // 
            this.резервнеВідновленняБДToolStripMenuItem.Name = "резервнеВідновленняБДToolStripMenuItem";
            this.резервнеВідновленняБДToolStripMenuItem.Size = new System.Drawing.Size(342, 28);
            this.резервнеВідновленняБДToolStripMenuItem.Text = "Резервне відновлення БД";
            this.резервнеВідновленняБДToolStripMenuItem.Click += new System.EventHandler(this.резервнеВідновленняБДToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(339, 6);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDlibrary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TablichiBD;
        private System.Windows.Forms.ToolStripMenuItem адмніструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькулятор1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькулятор2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Table1;
        private System.Windows.Forms.ToolStripMenuItem Table2;
        private System.Windows.Forms.ToolStripMenuItem додатиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиПарольКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиТипДоступуКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервнеКопіюванняБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервнеВідновленняБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

