using System.Linq;
namespace MyApplication
{
    public partial class Attendance : Infrastructure.BaseForm
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private static string checkchange(string day,string mounth, string year)
        {
            int yearnumber, mounthnumber, daynumber;

            yearnumber = System.Convert.ToInt32(year);
            daynumber = System.Convert.ToInt32(day);
            mounthnumber = Infrastructure.MountChange.nametonumber(mounth);

            PersianDate persianDate =
                Infrastructure.Utility.ConvertMiladiToShamsi(System.DateTime.Now);

            if (persianDate.Year>yearnumber)
            {
                return "Cancel";
            }
            else
            {
                if (persianDate.Year==yearnumber)
                {
                    if (persianDate.Month>mounthnumber)
                    {
                        return "Cancel";
                    }
                    else
                    {
                        if (persianDate.Month == 1 && mounthnumber == 12)
                        {
                            return "Cancel";
                        }
                        if (persianDate.Month==mounthnumber)
                        {
                            if (persianDate.Day > daynumber)
                            {
                                return "Cancel";
                            }
                        }
                    }
                }
            }
            return "Ok";
        }

        public void ChangeTime()
        {
            #region time8-9
            if (time8checkBox.Checked == true)
            {
                time8TextBox.Text = "آزاد";
                time8TextBox.BackColor = System.Drawing.Color.Khaki;
                time8TextBox.ForeColor = System.Drawing.Color.Green;
                time8TextBox.Enabled = true;
            }
            else
            {
                time8TextBox.BackColor = System.Drawing.Color.Red;
                time8TextBox.ForeColor = System.Drawing.Color.Black;
                time8TextBox.Enabled = false;
            }
            #endregion /time8-9

            #region time9-10
            if (time9checkBox.Checked == true)
            {
                time9TextBox.Text = "آزاد";
                time9TextBox.BackColor = System.Drawing.Color.Khaki;
                time9TextBox.ForeColor = System.Drawing.Color.Green;
                time9TextBox.Enabled = true;
            }
            else
            {
                time9TextBox.BackColor = System.Drawing.Color.Red;
                time9TextBox.ForeColor = System.Drawing.Color.Black;
                time9TextBox.Enabled = false;
            }
            #endregion /time9-10

            #region time10-11
            if (time10checkBox.Checked==true)
            {
                time10TextBox.Text = "آزاد";
                time10TextBox.BackColor = System.Drawing.Color.Khaki;
                time10TextBox.ForeColor = System.Drawing.Color.Green;
                time10TextBox.Enabled = true;
            }
            else
            {
                time10TextBox.BackColor = System.Drawing.Color.Red;
                time10TextBox.ForeColor = System.Drawing.Color.Black;
                time10TextBox.Enabled = false;
            }
            #endregion /time10-11

            #region time11-12
            if (time11checkBox.Checked==true)
            {
                time11TextBox.Text = "آزاد";
                time11TextBox.BackColor = System.Drawing.Color.Khaki;
                time11TextBox.ForeColor = System.Drawing.Color.Green;
                time11TextBox.Enabled = true;
            }
            else
            {
                time11TextBox.BackColor = System.Drawing.Color.Red;
                time11TextBox.ForeColor = System.Drawing.Color.Black;
                time11TextBox.Enabled = false;
            }
            #endregion /time11-12

            #region time12-13
            if (time12checkBox.Checked==true)
            {
                time12TextBox.Text = "آزاد";
                time12TextBox.BackColor = System.Drawing.Color.Khaki;
                time12TextBox.ForeColor = System.Drawing.Color.Green;
                time12TextBox.Enabled = true;
            }
            else
            {
                time12TextBox.BackColor = System.Drawing.Color.Red;
                time12TextBox.ForeColor = System.Drawing.Color.Black;
                time12TextBox.Enabled = false;
            }
            #endregion /time12-13

            #region time13-14
            if (time13checkBox.Checked==true)
            {
                time13TextBox.Text = "آزاد";
                time13TextBox.BackColor = System.Drawing.Color.Khaki;
                time13TextBox.ForeColor = System.Drawing.Color.Green;
                time13TextBox.Enabled = true;
            }
            else
            {
                time13TextBox.BackColor = System.Drawing.Color.Red;
                time13TextBox.ForeColor = System.Drawing.Color.Black;
                time13TextBox.Enabled = false;
            }
            #endregion /time13-14

            #region time14-15
            if (time14checkBox.Checked==true)
            {
                time14TextBox.Text = "آزاد";
                time14TextBox.BackColor = System.Drawing.Color.Khaki;
                time14TextBox.ForeColor = System.Drawing.Color.Green;
                time14TextBox.Enabled = true;
            }
            else
            {
                time14TextBox.BackColor = System.Drawing.Color.Red;
                time14TextBox.ForeColor = System.Drawing.Color.Black;
                time14TextBox.Enabled = false;
            }
            #endregion /time14-15

            #region time15-16
            if (time15checkBox.Checked==true)
            {
                time15TextBox.Text = "آزاد";
                time15TextBox.BackColor = System.Drawing.Color.Khaki;
                time15TextBox.ForeColor = System.Drawing.Color.Green;
                time15TextBox.Enabled = true;
            }
            else
            {
                time15TextBox.BackColor = System.Drawing.Color.Red;
                time15TextBox.ForeColor = System.Drawing.Color.Black;
                time15TextBox.Enabled = false;
            }
            #endregion /time15-16

            #region time16-17
            if (time16checkBox.Checked==true)
            {
                time16TextBox.Text = "آزاد";
                time16TextBox.BackColor = System.Drawing.Color.Khaki;
                time16TextBox.ForeColor = System.Drawing.Color.Green;
                time16TextBox.Enabled = true;
            }
            else
            {
                time16TextBox.BackColor = System.Drawing.Color.Red;
                time16TextBox.ForeColor = System.Drawing.Color.Black;
                time16TextBox.Enabled = false;
            }
            #endregion /time16-17

            #region time17-18
            if (time17checkBox.Checked==true)
            {
                time17TextBox.Text = "آزاد";
                time17TextBox.BackColor = System.Drawing.Color.Khaki;
                time17TextBox.ForeColor = System.Drawing.Color.Green;
                time17TextBox.Enabled = true;
            }
            else
            {
                time17TextBox.BackColor = System.Drawing.Color.Red;
                time17TextBox.ForeColor = System.Drawing.Color.Black;
                time17TextBox.Enabled = false;
            }
            #endregion /time17-18

            #region time18-19
            if (time18checkBox.Checked==true)
            {
                time18TextBox.Text = "آزاد";
                time18TextBox.BackColor = System.Drawing.Color.Khaki;
                time18TextBox.ForeColor = System.Drawing.Color.Green;
                time18TextBox.Enabled = true;
            }
            else
            {
                time18TextBox.BackColor = System.Drawing.Color.Red;
                time18TextBox.ForeColor = System.Drawing.Color.Black;
                time18TextBox.Enabled = false;
            }
            #endregion /time18-19

            #region time19-20
            if (time19checkBox.Checked==true)
            {
                time19TextBox.Text = "آزاد";
                time19TextBox.BackColor = System.Drawing.Color.Khaki;
                time19TextBox.ForeColor = System.Drawing.Color.Green;
                time19TextBox.Enabled = true;
            }
            else
            {
                time19TextBox.BackColor = System.Drawing.Color.Red;
                time19TextBox.ForeColor = System.Drawing.Color.Black;
                time19TextBox.Enabled = false;
            }
            #endregion /time19-20

            #region time20-21
            if (time20checkBox.Checked==true)
            {
                time20TextBox.Text = "آزاد";
                time20TextBox.BackColor = System.Drawing.Color.Khaki;
                time20TextBox.ForeColor = System.Drawing.Color.Green;
                time20TextBox.Enabled = true;
            }
            else
            {
                time20TextBox.BackColor = System.Drawing.Color.Red;
                time20TextBox.ForeColor = System.Drawing.Color.Black;
                time20TextBox.Enabled = false;
            }
            #endregion /time20-21

            #region time21-22
            if (time21checkBox.Checked==true)
            {
                time21TextBox.Text = "آزاد";
                time21TextBox.BackColor = System.Drawing.Color.Khaki;
                time21TextBox.ForeColor = System.Drawing.Color.Green;
                time21TextBox.Enabled = true;
            }
            else
            {
                time21TextBox.BackColor = System.Drawing.Color.Red;
                time21TextBox.ForeColor = System.Drawing.Color.Black;
                time21TextBox.Enabled = false;
            }
            #endregion /time21-22
        }
       
        private void attendance_Load(object sender, System.EventArgs e)
        {
            int minDay, minMounth, minYeaer;

            PersianDate persianDate =
                Infrastructure.Utility.ConvertMiladiToShamsi(System.DateTime.Now);

            minDay = persianDate.Day;
            minMounth = persianDate.Month;
            minYeaer = persianDate.Year;

            yearLabel.Text = minYeaer.ToString();
            dayLabel.Text = minDay.ToString();

            mounthLabel.Text = Infrastructure.MountChange.numbertoname(minMounth);

            ChangeTime();

        }

        #region calender code
        private void nextYearButton_Click(object sender, System.EventArgs e)
        {
            priviosYearButton.Enabled = true;

            int year;

            year = System.Convert.ToInt32(yearLabel.Text);

            year++;

            yearLabel.Text = year.ToString();
        }

        private void priviosYearButton_Click(object sender, System.EventArgs e)
        {
            int year;

            year = System.Convert.ToInt32(yearLabel.Text);

            year--;

            string result =
                checkchange(dayLabel.Text, mounthLabel.Text, year.ToString());
            if (result!="Ok")
            {
                priviosYearButton.Enabled = false;
                return;
            }
            yearLabel.Text = year.ToString();
        }

        private void nextDayButton_Click(object sender, System.EventArgs e)
        {
            priviosDayButton.Enabled = true;

            int day;

            day = System.Convert.ToInt32(dayLabel.Text);

            if (day>29)
            {
                if (mounthLabel.Text == "فروردین" ||
                    mounthLabel.Text == "اردیبهشت" ||
                    mounthLabel.Text == "خرداد" ||
                    mounthLabel.Text == "تیر" ||
                    mounthLabel.Text == "مرداد" ||
                    mounthLabel.Text == "شهریور")
                {
                    if (day==31)
                    {
                        day = 1;

                        dayLabel.Text = day.ToString();

                        return;
                    }
                    day++;

                    dayLabel.Text = day.ToString();

                    return;
                }

                day = 1;

                dayLabel.Text = day.ToString();

                return;
            }

            day++;

            dayLabel.Text = day.ToString();

            return;
        }

        private void priviosDayButton_Click(object sender, System.EventArgs e)
        {
            int day;

            day = System.Convert.ToInt32(dayLabel.Text);

            if (day == 1)
            {
                if (mounthLabel.Text == "فروردین" ||
                    mounthLabel.Text == "اردیبهشت" ||
                    mounthLabel.Text == "خرداد" ||
                    mounthLabel.Text == "تیر" ||
                    mounthLabel.Text == "مرداد" ||
                    mounthLabel.Text == "شهریور")
                {
                    day = 31;

                    dayLabel.Text = day.ToString();

                    return;
                }
                day = 30;

                dayLabel.Text = day.ToString();

                return;
            }

            day--;

            string result =
                checkchange(day.ToString(), mounthLabel.Text, yearLabel.Text);

            if (result != "Ok")
            {
                priviosDayButton.Enabled = false;

                return;
            }

            dayLabel.Text = day.ToString();

            return;
        }

        private void nextMounthButton_Click(object sender, System.EventArgs e)
        {
            priviosMountButton.Enabled = true;

            mounthLabel.Text = Infrastructure.MountChange.nextmountname(mounthLabel.Text);
        }

        private void priviosMountButton_Click(object sender, System.EventArgs e)
        {
            string mounth = string.Empty;

            mounth = Infrastructure.MountChange.previousmountname(mounthLabel.Text);

            string result =
                checkchange(dayLabel.Text, mounth, yearLabel.Text);

            if (result != "Ok")
            {
                priviosMountButton.Enabled = false;
                return;
            }

            mounthLabel.Text = mounth;
        }
        #endregion / calender code

        #region checkbox code
        private void time8checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time8checkBox.Checked == true)
            {
                time8TextBox.Text = "آزاد";
                time8TextBox.BackColor = System.Drawing.Color.Khaki;
                time8TextBox.ForeColor = System.Drawing.Color.Green;
                time8TextBox.Enabled = true;
            }
            else
            {
                time8TextBox.Text = "حضور ندارند";
                time8TextBox.BackColor = System.Drawing.Color.Red;
                time8TextBox.ForeColor = System.Drawing.Color.Black;
                time8TextBox.Enabled = false;
            }
        }

        private void time9checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time9checkBox.Checked == true)
            {
                time9TextBox.Text = "آزاد";
                time9TextBox.BackColor = System.Drawing.Color.Khaki;
                time9TextBox.ForeColor = System.Drawing.Color.Green;
                time9TextBox.Enabled = true;
            }
            else
            {
                time9TextBox.Text = "حضور ندارند";
                time9TextBox.BackColor = System.Drawing.Color.Red;
                time9TextBox.ForeColor = System.Drawing.Color.Black;
                time9TextBox.Enabled = false;
            }
        }

        private void time10checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time10checkBox.Checked == true)
            {
                time10TextBox.Text = "آزاد";
                time10TextBox.BackColor = System.Drawing.Color.Khaki;
                time10TextBox.ForeColor = System.Drawing.Color.Green;
                time10TextBox.Enabled = true;
            }
            else
            {
                time10TextBox.Text = "حضور ندارند";
                time10TextBox.BackColor = System.Drawing.Color.Red;
                time10TextBox.ForeColor = System.Drawing.Color.Black;
                time10TextBox.Enabled = false;
            }
        }

        private void time11checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time11checkBox.Checked == true)
            {
                time11TextBox.Text = "آزاد";
                time11TextBox.BackColor = System.Drawing.Color.Khaki;
                time11TextBox.ForeColor = System.Drawing.Color.Green;
                time11TextBox.Enabled = true;
            }
            else
            {
                time11TextBox.Text = "حضور ندارند";
                time11TextBox.BackColor = System.Drawing.Color.Red;
                time11TextBox.ForeColor = System.Drawing.Color.Black;
                time11TextBox.Enabled = false;
            }
        }

        private void time12checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time12checkBox.Checked == true)
            {
                time12TextBox.Text = "آزاد";
                time12TextBox.BackColor = System.Drawing.Color.Khaki;
                time12TextBox.ForeColor = System.Drawing.Color.Green;
                time12TextBox.Enabled = true;
            }
            else
            {
                time12TextBox.Text = "حضور ندارند";
                time12TextBox.BackColor = System.Drawing.Color.Red;
                time12TextBox.ForeColor = System.Drawing.Color.Black;
                time12TextBox.Enabled = false;
            }
        }

        private void time13checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time13checkBox.Checked == true)
            {
                time13TextBox.Text = "آزاد";
                time13TextBox.BackColor = System.Drawing.Color.Khaki;
                time13TextBox.ForeColor = System.Drawing.Color.Green;
                time13TextBox.Enabled = true;
            }
            else
            {
                time13TextBox.Text = "حضور ندارند";
                time13TextBox.BackColor = System.Drawing.Color.Red;
                time13TextBox.ForeColor = System.Drawing.Color.Black;
                time13TextBox.Enabled = false;
            }
        }

        private void time14checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time14checkBox.Checked == true)
            {
                time14TextBox.Text = "آزاد";
                time14TextBox.BackColor = System.Drawing.Color.Khaki;
                time14TextBox.ForeColor = System.Drawing.Color.Green;
                time14TextBox.Enabled = true;
            }
            else
            {
                time14TextBox.Text = "حضور ندارند";
                time14TextBox.BackColor = System.Drawing.Color.Red;
                time14TextBox.ForeColor = System.Drawing.Color.Black;
                time14TextBox.Enabled = false;
            }
        }

        private void time15checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time15checkBox.Checked == true)
            {
                time15TextBox.Text = "آزاد";
                time15TextBox.BackColor = System.Drawing.Color.Khaki;
                time15TextBox.ForeColor = System.Drawing.Color.Green;
                time15TextBox.Enabled = true;
            }
            else
            {
                time15TextBox.Text = "حضور ندارند";
                time15TextBox.BackColor = System.Drawing.Color.Red;
                time15TextBox.ForeColor = System.Drawing.Color.Black;
                time15TextBox.Enabled = false;
            }
        }

        private void time16checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time16checkBox.Checked == true)
            {
                time16TextBox.Text = "آزاد";
                time16TextBox.BackColor = System.Drawing.Color.Khaki;
                time16TextBox.ForeColor = System.Drawing.Color.Green;
                time16TextBox.Enabled = true;
            }
            else
            {
                time16TextBox.Text = "حضور ندارند";
                time16TextBox.BackColor = System.Drawing.Color.Red;
                time16TextBox.ForeColor = System.Drawing.Color.Black;
                time16TextBox.Enabled = false;
            }
        }

        private void time17checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time17checkBox.Checked == true)
            {
                time17TextBox.Text = "آزاد";
                time17TextBox.BackColor = System.Drawing.Color.Khaki;
                time17TextBox.ForeColor = System.Drawing.Color.Green;
                time17TextBox.Enabled = true;
            }
            else
            {
                time17TextBox.Text = "حضور ندارند";
                time17TextBox.BackColor = System.Drawing.Color.Red;
                time17TextBox.ForeColor = System.Drawing.Color.Black;
                time17TextBox.Enabled = false;
            }
            ChangeTime();
        }

        private void time18checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time18checkBox.Checked == true)
            {
                time18TextBox.Text = "آزاد";
                time18TextBox.BackColor = System.Drawing.Color.Khaki;
                time18TextBox.ForeColor = System.Drawing.Color.Green;
                time18TextBox.Enabled = true;
            }
            else
            {
                time18TextBox.Text = "حضور ندارند";
                time18TextBox.BackColor = System.Drawing.Color.Red;
                time18TextBox.ForeColor = System.Drawing.Color.Black;
                time18TextBox.Enabled = false;
            }
        }

        private void time19checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time19checkBox.Checked == true)
            {
                time19TextBox.Text = "آزاد";
                time19TextBox.BackColor = System.Drawing.Color.Khaki;
                time19TextBox.ForeColor = System.Drawing.Color.Green;
                time19TextBox.Enabled = true;
            }
            else
            {
                time19TextBox.Text = "حضور ندارند";
                time19TextBox.BackColor = System.Drawing.Color.Red;
                time19TextBox.ForeColor = System.Drawing.Color.Black;
                time19TextBox.Enabled = false;
            }
        }

        private void time20checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time20checkBox.Checked == true)
            {
                time20TextBox.Text = "آزاد";
                time20TextBox.BackColor = System.Drawing.Color.Khaki;
                time20TextBox.ForeColor = System.Drawing.Color.Green;
                time20TextBox.Enabled = true;
            }
            else
            {
                time20TextBox.Text = "حضور ندارند";
                time20TextBox.BackColor = System.Drawing.Color.Red;
                time20TextBox.ForeColor = System.Drawing.Color.Black;
                time20TextBox.Enabled = false;
            }
        }

        private void time21checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (time21checkBox.Checked == true)
            {
                time21TextBox.Text = "آزاد";
                time21TextBox.BackColor = System.Drawing.Color.Khaki;
                time21TextBox.ForeColor = System.Drawing.Color.Green;
                time21TextBox.Enabled = true;
            }
            else
            {
                time21TextBox.Text = "حضور ندارند";
                time21TextBox.BackColor = System.Drawing.Color.Red;
                time21TextBox.ForeColor = System.Drawing.Color.Black;
                time21TextBox.Enabled = false;
            }
        }
        #endregion /checkbox code

        #region textbox code
        private void time8TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time8TextBox.Text == "آزاد")
            {
                time8checkBox.Checked = true;
                time8checkBox.Enabled = true;

                time8TextBox.BackColor = System.Drawing.Color.Khaki;
                time8TextBox.ForeColor = System.Drawing.Color.Green;

                time8TextBox.Enabled = true;

                return;
            }

            if (time8TextBox.Text == "حضور ندارند")
            {
                time8checkBox.Checked = false;
                time8checkBox.Enabled = true;

                time8TextBox.BackColor = System.Drawing.Color.Red;
                time8TextBox.ForeColor = System.Drawing.Color.Black;

                time8TextBox.Enabled = true;

                return;
            }

            time8checkBox.Checked = false;
            time8checkBox.Enabled = false;

            time8TextBox.BackColor = System.Drawing.Color.Red;
            time8TextBox.ForeColor = System.Drawing.Color.Black;

            time8TextBox.Enabled = false;

            return;
        }

        private void time9TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time9TextBox.Text == "آزاد")
            {
                time9checkBox.Checked = true;
                time9checkBox.Enabled = true;

                time9TextBox.BackColor = System.Drawing.Color.Khaki;
                time9TextBox.ForeColor = System.Drawing.Color.Green;

                time9TextBox.Enabled = true;

                return;
            }

            if (time9TextBox.Text == "حضور ندارند")
            {
                time9checkBox.Checked = false;
                time9checkBox.Enabled = true;

                time9TextBox.BackColor = System.Drawing.Color.Red;
                time9TextBox.ForeColor = System.Drawing.Color.Black;

                time9TextBox.Enabled = true;

                return;
            }

            time9checkBox.Checked = false;
            time9checkBox.Enabled = false;

            time9TextBox.BackColor = System.Drawing.Color.Red;
            time9TextBox.ForeColor = System.Drawing.Color.Black;

            time9TextBox.Enabled = false;

            return;
        }

        private void time10TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time10TextBox.Text == "آزاد")
            {
                time10checkBox.Checked = true;
                time10checkBox.Enabled = true;

                time10TextBox.BackColor = System.Drawing.Color.Khaki;
                time10TextBox.ForeColor = System.Drawing.Color.Green;

                time10TextBox.Enabled = true;

                return;
            }

            if (time10TextBox.Text == "حضور ندارند")
            {
                time10checkBox.Checked = false;
                time10checkBox.Enabled = true;

                time10TextBox.BackColor = System.Drawing.Color.Red;
                time10TextBox.ForeColor = System.Drawing.Color.Black;

                time10TextBox.Enabled = true;

                return;
            }

            time10checkBox.Checked = false;
            time10checkBox.Enabled = false;

            time10TextBox.BackColor = System.Drawing.Color.Red;
            time10TextBox.ForeColor = System.Drawing.Color.Black;

            time10TextBox.Enabled = false;

            return;
        }

        private void time11TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time11TextBox.Text == "آزاد")
            {
                time11checkBox.Checked = true;
                time11checkBox.Enabled = true;

                time11TextBox.BackColor = System.Drawing.Color.Khaki;
                time11TextBox.ForeColor = System.Drawing.Color.Green;

                time11TextBox.Enabled = true;

                return;
            }

            if (time11TextBox.Text == "حضور ندارند")
            {
                time11checkBox.Checked = false;
                time11checkBox.Enabled = true;

                time11TextBox.BackColor = System.Drawing.Color.Red;
                time11TextBox.ForeColor = System.Drawing.Color.Black;

                time11TextBox.Enabled = true;

                return;
            }

            time11checkBox.Checked = false;
            time11checkBox.Enabled = false;

            time11TextBox.BackColor = System.Drawing.Color.Red;
            time11TextBox.ForeColor = System.Drawing.Color.Black;

            time11TextBox.Enabled = false;

            return;
        }

        private void time12TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time12TextBox.Text == "آزاد")
            {
                time12checkBox.Checked = true;
                time12checkBox.Enabled = true;

                time12TextBox.BackColor = System.Drawing.Color.Khaki;
                time12TextBox.ForeColor = System.Drawing.Color.Green;

                time12TextBox.Enabled = true;

                return;
            }

            if (time12TextBox.Text == "حضور ندارند")
            {
                time12checkBox.Checked = false;
                time12checkBox.Enabled = true;

                time12TextBox.BackColor = System.Drawing.Color.Red;
                time12TextBox.ForeColor = System.Drawing.Color.Black;

                time12TextBox.Enabled = true;

                return;
            }

            time12checkBox.Checked = false;
            time12checkBox.Enabled = false;

            time12TextBox.BackColor = System.Drawing.Color.Red;
            time12TextBox.ForeColor = System.Drawing.Color.Black;

            time12TextBox.Enabled = false;

            return;
        }

        private void time13TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time13TextBox.Text == "آزاد")
            {
                time13checkBox.Checked = true;
                time13checkBox.Enabled = true;

                time13TextBox.BackColor = System.Drawing.Color.Khaki;
                time13TextBox.ForeColor = System.Drawing.Color.Green;

                time13TextBox.Enabled = true;

                return;
            }

            if (time13TextBox.Text == "حضور ندارند")
            {
                time13checkBox.Checked = false;
                time13checkBox.Enabled = true;

                time13TextBox.BackColor = System.Drawing.Color.Red;
                time13TextBox.ForeColor = System.Drawing.Color.Black;

                time13TextBox.Enabled = true;

                return;
            }

            time13checkBox.Checked = false;
            time13checkBox.Enabled = false;

            time13TextBox.BackColor = System.Drawing.Color.Red;
            time13TextBox.ForeColor = System.Drawing.Color.Black;

            time13TextBox.Enabled = false;

            return;
        }

        private void time14TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time14TextBox.Text == "آزاد")
            {
                time14checkBox.Checked = true;
                time14checkBox.Enabled = true;

                time14TextBox.BackColor = System.Drawing.Color.Khaki;
                time14TextBox.ForeColor = System.Drawing.Color.Green;

                time14TextBox.Enabled = true;

                return;
            }

            if (time14TextBox.Text == "حضور ندارند")
            {
                time14checkBox.Checked = false;
                time14checkBox.Enabled = true;

                time14TextBox.BackColor = System.Drawing.Color.Red;
                time14TextBox.ForeColor = System.Drawing.Color.Black;

                time14TextBox.Enabled = true;

                return;
            }

            time14checkBox.Checked = false;
            time14checkBox.Enabled = false;

            time14TextBox.BackColor = System.Drawing.Color.Red;
            time14TextBox.ForeColor = System.Drawing.Color.Black;

            time14TextBox.Enabled = false;

            return;
        }

        private void time15TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time15TextBox.Text == "آزاد")
            {
                time15checkBox.Checked = true;
                time15checkBox.Enabled = true;

                time15TextBox.BackColor = System.Drawing.Color.Khaki;
                time15TextBox.ForeColor = System.Drawing.Color.Green;

                time15TextBox.Enabled = true;

                return;
            }

            if (time15TextBox.Text == "حضور ندارند")
            {
                time15checkBox.Checked = false;
                time15checkBox.Enabled = true;

                time15TextBox.BackColor = System.Drawing.Color.Red;
                time15TextBox.ForeColor = System.Drawing.Color.Black;

                time15TextBox.Enabled = true;

                return;
            }

            time15checkBox.Checked = false;
            time15checkBox.Enabled = false;

            time15TextBox.BackColor = System.Drawing.Color.Red;
            time15TextBox.ForeColor = System.Drawing.Color.Black;

            time15TextBox.Enabled = false;

            return;
        }

        private void time16TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time16TextBox.Text == "آزاد")
            {
                time16checkBox.Checked = true;
                time16checkBox.Enabled = true;

                time16TextBox.BackColor = System.Drawing.Color.Khaki;
                time16TextBox.ForeColor = System.Drawing.Color.Green;

                time16TextBox.Enabled = true;

                return;
            }

            if (time16TextBox.Text == "حضور ندارند")
            {
                time16checkBox.Checked = false;
                time16checkBox.Enabled = true;

                time16TextBox.BackColor = System.Drawing.Color.Red;
                time16TextBox.ForeColor = System.Drawing.Color.Black;

                time16TextBox.Enabled = true;

                return;
            }

            time16checkBox.Checked = false;
            time16checkBox.Enabled = false;

            time16TextBox.BackColor = System.Drawing.Color.Red;
            time16TextBox.ForeColor = System.Drawing.Color.Black;

            time16TextBox.Enabled = false;

            return;
        }

        private void time17TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time17TextBox.Text == "آزاد")
            {
                time17checkBox.Checked = true;
                time17checkBox.Enabled = true;

                time17TextBox.BackColor = System.Drawing.Color.Khaki;
                time17TextBox.ForeColor = System.Drawing.Color.Green;

                time17TextBox.Enabled = true;

                return;
            }

            if (time17TextBox.Text == "حضور ندارند")
            {
                time17checkBox.Checked = false;
                time17checkBox.Enabled = true;

                time17TextBox.BackColor = System.Drawing.Color.Red;
                time17TextBox.ForeColor = System.Drawing.Color.Black;

                time17TextBox.Enabled = true;

                return;
            }

            time17checkBox.Checked = false;
            time17checkBox.Enabled = false;

            time17TextBox.BackColor = System.Drawing.Color.Red;
            time17TextBox.ForeColor = System.Drawing.Color.Black;

            time17TextBox.Enabled = false;

            return;
        }

        private void time18TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time18TextBox.Text == "آزاد")
            {
                time18checkBox.Checked = true;
                time18checkBox.Enabled = true;

                time18TextBox.BackColor = System.Drawing.Color.Khaki;
                time18TextBox.ForeColor = System.Drawing.Color.Green;

                time18TextBox.Enabled = true;

                return;
            }

            if (time18TextBox.Text == "حضور ندارند")
            {
                time18checkBox.Checked = false;
                time18checkBox.Enabled = true;

                time18TextBox.BackColor = System.Drawing.Color.Red;
                time18TextBox.ForeColor = System.Drawing.Color.Black;

                time18TextBox.Enabled = true;

                return;
            }

            time18checkBox.Checked = false;
            time18checkBox.Enabled = false;

            time18TextBox.BackColor = System.Drawing.Color.Red;
            time18TextBox.ForeColor = System.Drawing.Color.Black;

            time18TextBox.Enabled = false;

            return;
        }

        private void time19TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time19TextBox.Text == "آزاد")
            {
                time19checkBox.Checked = true;
                time19checkBox.Enabled = true;

                time19TextBox.BackColor = System.Drawing.Color.Khaki;
                time19TextBox.ForeColor = System.Drawing.Color.Green;

                time19TextBox.Enabled = true;

                return;
            }

            if (time19TextBox.Text == "حضور ندارند")
            {
                time19checkBox.Checked = false;
                time19checkBox.Enabled = true;

                time19TextBox.BackColor = System.Drawing.Color.Red;
                time19TextBox.ForeColor = System.Drawing.Color.Black;

                time19TextBox.Enabled = true;

                return;
            }

            time19checkBox.Checked = false;
            time19checkBox.Enabled = false;

            time19TextBox.BackColor = System.Drawing.Color.Red;
            time19TextBox.ForeColor = System.Drawing.Color.Black;

            time19TextBox.Enabled = false;

            return;
        }

        private void time20TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time20TextBox.Text == "آزاد")
            {
                time20checkBox.Checked = true;
                time20checkBox.Enabled = true;

                time20TextBox.BackColor = System.Drawing.Color.Khaki;
                time20TextBox.ForeColor = System.Drawing.Color.Green;

                time20TextBox.Enabled = true;

                return;
            }

            if (time20TextBox.Text == "حضور ندارند")
            {
                time20checkBox.Checked = false;
                time20checkBox.Enabled = true;

                time20TextBox.BackColor = System.Drawing.Color.Red;
                time20TextBox.ForeColor = System.Drawing.Color.Black;

                time20TextBox.Enabled = true;

                return;
            }

            time20checkBox.Checked = false;
            time20checkBox.Enabled = false;

            time20TextBox.BackColor = System.Drawing.Color.Red;
            time20TextBox.ForeColor = System.Drawing.Color.Black;

            time20TextBox.Enabled = false;

            return;
        }

        private void time21TextBox_Leave(object sender, System.EventArgs e)
        {
            if (time21TextBox.Text == "آزاد")
            {
                time21checkBox.Checked = true;
                time21checkBox.Enabled = true;

                time21TextBox.BackColor = System.Drawing.Color.Khaki;
                time21TextBox.ForeColor = System.Drawing.Color.Green;

                time21TextBox.Enabled = true;

                return;
            }

            if (time21TextBox.Text == "حضور ندارند")
            {
                time21checkBox.Checked = false;
                time21checkBox.Enabled = true;

                time21TextBox.BackColor = System.Drawing.Color.Red;
                time21TextBox.ForeColor = System.Drawing.Color.Black;

                time21TextBox.Enabled = true;

                return;
            }

            time21checkBox.Checked = false;
            time21checkBox.Enabled = false;

            time21TextBox.BackColor = System.Drawing.Color.Red;
            time21TextBox.ForeColor = System.Drawing.Color.Black;

            time21TextBox.Enabled = false;

            return;
        }

        #endregion /textbox code

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
