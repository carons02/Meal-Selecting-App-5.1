namespace FoodSelectorApp
{
    partial class FoodSelectorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodSelectorMain));
            this.groupBoxMenuOptions = new System.Windows.Forms.GroupBox();
            this.textBoxMenuOptions = new System.Windows.Forms.TextBox();
            this.radioButtonBreakfast = new System.Windows.Forms.RadioButton();
            this.radioButtonLunch = new System.Windows.Forms.RadioButton();
            this.radioButtonDinner = new System.Windows.Forms.RadioButton();
            this.radioButton4Meal = new System.Windows.Forms.RadioButton();
            this.MealTimeLabel = new System.Windows.Forms.Label();
            this.groupBoxMealChoice = new System.Windows.Forms.GroupBox();
            this.groupBoxMenuOptions.SuspendLayout();
            this.groupBoxMealChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenuOptions
            // 
            this.groupBoxMenuOptions.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxMenuOptions.Controls.Add(this.textBoxMenuOptions);
            this.groupBoxMenuOptions.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenuOptions.Location = new System.Drawing.Point(12, 187);
            this.groupBoxMenuOptions.Name = "groupBoxMenuOptions";
            this.groupBoxMenuOptions.Size = new System.Drawing.Size(1060, 440);
            this.groupBoxMenuOptions.TabIndex = 0;
            this.groupBoxMenuOptions.TabStop = false;
            this.groupBoxMenuOptions.Text = "Menu Options";
            // 
            // textBoxMenuOptions
            // 
            this.textBoxMenuOptions.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenuOptions.Location = new System.Drawing.Point(33, 43);
            this.textBoxMenuOptions.Multiline = true;
            this.textBoxMenuOptions.Name = "textBoxMenuOptions";
            this.textBoxMenuOptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMenuOptions.Size = new System.Drawing.Size(992, 351);
            this.textBoxMenuOptions.TabIndex = 0;
            // 
            // radioButtonBreakfast
            // 
            this.radioButtonBreakfast.AutoSize = true;
            this.radioButtonBreakfast.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBreakfast.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBreakfast.Location = new System.Drawing.Point(66, 21);
            this.radioButtonBreakfast.Name = "radioButtonBreakfast";
            this.radioButtonBreakfast.Size = new System.Drawing.Size(132, 30);
            this.radioButtonBreakfast.TabIndex = 1;
            this.radioButtonBreakfast.TabStop = true;
            this.radioButtonBreakfast.Text = "Breakfast";
            this.radioButtonBreakfast.UseVisualStyleBackColor = false;
            this.radioButtonBreakfast.CheckedChanged += new System.EventHandler(this.radioButtonBreakfast_CheckedChanged);
            // 
            // radioButtonLunch
            // 
            this.radioButtonLunch.AutoSize = true;
            this.radioButtonLunch.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLunch.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLunch.Location = new System.Drawing.Point(257, 21);
            this.radioButtonLunch.Name = "radioButtonLunch";
            this.radioButtonLunch.Size = new System.Drawing.Size(87, 30);
            this.radioButtonLunch.TabIndex = 2;
            this.radioButtonLunch.TabStop = true;
            this.radioButtonLunch.Text = "Lunch";
            this.radioButtonLunch.UseVisualStyleBackColor = false;
            this.radioButtonLunch.CheckedChanged += new System.EventHandler(this.radioButtonLunch_CheckedChanged);
            // 
            // radioButtonDinner
            // 
            this.radioButtonDinner.AutoSize = true;
            this.radioButtonDinner.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDinner.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDinner.Location = new System.Drawing.Point(442, 21);
            this.radioButtonDinner.Name = "radioButtonDinner";
            this.radioButtonDinner.Size = new System.Drawing.Size(94, 30);
            this.radioButtonDinner.TabIndex = 3;
            this.radioButtonDinner.TabStop = true;
            this.radioButtonDinner.Text = "Dinner";
            this.radioButtonDinner.UseVisualStyleBackColor = false;
            this.radioButtonDinner.CheckedChanged += new System.EventHandler(this.radioButtonDinner_CheckedChanged);
            // 
            // radioButton4Meal
            // 
            this.radioButton4Meal.AutoSize = true;
            this.radioButton4Meal.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4Meal.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4Meal.Location = new System.Drawing.Point(615, 21);
            this.radioButton4Meal.Name = "radioButton4Meal";
            this.radioButton4Meal.Size = new System.Drawing.Size(123, 30);
            this.radioButton4Meal.TabIndex = 4;
            this.radioButton4Meal.TabStop = true;
            this.radioButton4Meal.Text = "4th Meal";
            this.radioButton4Meal.UseVisualStyleBackColor = false;
            this.radioButton4Meal.CheckedChanged += new System.EventHandler(this.radioButton4Meal_CheckedChanged);
            // 
            // MealTimeLabel
            // 
            this.MealTimeLabel.AutoSize = true;
            this.MealTimeLabel.BackColor = System.Drawing.Color.White;
            this.MealTimeLabel.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealTimeLabel.Location = new System.Drawing.Point(327, 21);
            this.MealTimeLabel.Name = "MealTimeLabel";
            this.MealTimeLabel.Size = new System.Drawing.Size(430, 60);
            this.MealTimeLabel.TabIndex = 5;
            this.MealTimeLabel.Text = "Select a Meal Time";
            // 
            // groupBoxMealChoice
            // 
            this.groupBoxMealChoice.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxMealChoice.Controls.Add(this.radioButtonDinner);
            this.groupBoxMealChoice.Controls.Add(this.radioButtonBreakfast);
            this.groupBoxMealChoice.Controls.Add(this.radioButton4Meal);
            this.groupBoxMealChoice.Controls.Add(this.radioButtonLunch);
            this.groupBoxMealChoice.Location = new System.Drawing.Point(142, 95);
            this.groupBoxMealChoice.Name = "groupBoxMealChoice";
            this.groupBoxMealChoice.Size = new System.Drawing.Size(798, 71);
            this.groupBoxMealChoice.TabIndex = 6;
            this.groupBoxMealChoice.TabStop = false;
            // 
            // FoodSelectorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.groupBoxMealChoice);
            this.Controls.Add(this.MealTimeLabel);
            this.Controls.Add(this.groupBoxMenuOptions);
            this.MaximumSize = new System.Drawing.Size(1100, 699);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "FoodSelectorMain";
            this.Text = "Food Selector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMenuOptions.ResumeLayout(false);
            this.groupBoxMenuOptions.PerformLayout();
            this.groupBoxMealChoice.ResumeLayout(false);
            this.groupBoxMealChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenuOptions;
        private System.Windows.Forms.TextBox textBoxMenuOptions;
        private System.Windows.Forms.RadioButton radioButtonBreakfast;
        private System.Windows.Forms.RadioButton radioButtonLunch;
        private System.Windows.Forms.RadioButton radioButtonDinner;
        private System.Windows.Forms.RadioButton radioButton4Meal;
        private System.Windows.Forms.Label MealTimeLabel;
        private System.Windows.Forms.GroupBox groupBoxMealChoice;
    }
}

