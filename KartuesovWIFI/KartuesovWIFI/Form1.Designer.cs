
namespace KartuesovWIFI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listNet = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNet
            // 
            this.listNet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SSID,
            this.Signal,
            this.Type,
            this.Crypt});
            this.listNet.HideSelection = false;
            this.listNet.LargeImageList = this.imageList1;
            this.listNet.Location = new System.Drawing.Point(28, 40);
            this.listNet.Name = "listNet";
            this.listNet.Size = new System.Drawing.Size(594, 382);
            this.listNet.SmallImageList = this.imageList1;
            this.listNet.TabIndex = 0;
            this.listNet.UseCompatibleStateImageBehavior = false;
            this.listNet.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kisspng-wi-fi-wide-awake-club-library-central-library-inte-wifi-5b4a67b066e945.95" +
        "74851115316028644215.jpg");
            // 
            // SSID
            // 
            this.SSID.Text = "SSID";
            this.SSID.Width = 100;
            // 
            // Signal
            // 
            this.Signal.Text = "Качество";
            this.Signal.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Тип безопасности";
            this.Type.Width = 100;
            // 
            // Crypt
            // 
            this.Crypt.Text = "Тип шифрования";
            this.Crypt.Width = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(663, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listNet);
            this.Name = "Form1";
            this.Text = "Wi-Fi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNet;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.ColumnHeader Signal;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Crypt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

