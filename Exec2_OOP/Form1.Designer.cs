namespace Exec2_OOP4
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tryTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.newGameButton = new System.Windows.Forms.Button();
			this.tryButton = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tryTextBox
			// 
			this.tryTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tryTextBox.Location = new System.Drawing.Point(110, 219);
			this.tryTextBox.Multiline = true;
			this.tryTextBox.Name = "tryTextBox";
			this.tryTextBox.ReadOnly = true;
			this.tryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tryTextBox.Size = new System.Drawing.Size(324, 314);
			this.tryTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(105, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "請輸入四位數字";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.inputTextBox.Location = new System.Drawing.Point(110, 156);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(154, 39);
			this.inputTextBox.TabIndex = 2;
			this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// newGameButton
			// 
			this.newGameButton.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.newGameButton.Location = new System.Drawing.Point(328, 111);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(106, 39);
			this.newGameButton.TabIndex = 3;
			this.newGameButton.Text = "新遊戲";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// tryButton
			// 
			this.tryButton.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tryButton.Location = new System.Drawing.Point(328, 156);
			this.tryButton.Name = "tryButton";
			this.tryButton.Size = new System.Drawing.Size(106, 39);
			this.tryButton.TabIndex = 4;
			this.tryButton.Text = "試試看";
			this.tryButton.UseVisualStyleBackColor = true;
			this.tryButton.Click += new System.EventHandler(this.tryButton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.answerLabel.Location = new System.Drawing.Point(106, 571);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(62, 31);
			this.answerLabel.TabIndex = 5;
			this.answerLabel.Text = "答案";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.titleLabel.Location = new System.Drawing.Point(158, 32);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(228, 46);
			this.titleLabel.TabIndex = 6;
			this.titleLabel.Text = "1A2B 猜遊戲";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 660);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.tryButton);
			this.Controls.Add(this.newGameButton);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tryTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tryTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button tryButton;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Label titleLabel;
	}
}

