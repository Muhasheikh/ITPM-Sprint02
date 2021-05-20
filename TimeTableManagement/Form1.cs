using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAndTagsManagement
{
    public partial class Form1 : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton( object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSide.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }

            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonWorkingDays_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           WorkControl wk = new WorkControl();
            MainControl.ShowControl(wk, panelForm);
        }

        private void buttonWorkingHours_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
           OpenChildForm(new Forms.FormStudentManagement(), sender);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
           OpenChildForm(new Forms.FormTagManagement(), sender);
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {

        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.FormSessionManagement(), sender);
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
   
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnAvailabilityM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AvaControl wk = new AvaControl();
            MainControl.ShowControl(wk, panelForm);
        }

        private void BtnRoomM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnStatM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
