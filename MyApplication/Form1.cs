using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        using System.Linq;
//namespace MyApplication
//    {
//        public partial class AttendanceForm : Infrastructure.BaseForm
//        {
//            public AttendanceForm()
//            {
//                InitializeComponent();
//            }

//            #region Public field

//            private string doctor = string.Empty;

//            private string date = string.Empty;

//            private bool DatabaseChange = false;

//            private string TextBoxEnterText = string.Empty;

//            private Models.Reservations VisitDateDoctor;

//            #endregion /public fielda

//            #region Calender Function
//            private static string checkchange(string day, string mounth, string year)
//            {
//                int yearnumber, mounthnumber, daynumber;

//                yearnumber = System.Convert.ToInt32(year);
//                daynumber = System.Convert.ToInt32(day);
//                mounthnumber = Infrastructure.MountChange.nametonumber(mounth);

//                PersianDate persianDate =
//                    Infrastructure.Utility.ConvertMiladiToShamsi(System.DateTime.Now);

//                if (persianDate.Year > yearnumber)
//                {
//                    return "Cancel";
//                }
//                else
//                {
//                    if (persianDate.Year == yearnumber)
//                    {
//                        if (persianDate.Month > mounthnumber)
//                        {
//                            return "Cancel";
//                        }
//                        else
//                        {
//                            if (persianDate.Month == 1 && mounthnumber == 12)
//                            {
//                                return "Cancel";
//                            }
//                            if (persianDate.Month == mounthnumber)
//                            {
//                                if (persianDate.Day > daynumber)
//                                {
//                                    return "Cancel";
//                                }
//                            }
//                        }
//                    }
//                }
//                return "Ok";
//            }

//            public void CreateDate()
//            {
//                int minDay, minMounth, minYeaer;

//                PersianDate persianDate =
//                    Infrastructure.Utility.ConvertMiladiToShamsi(System.DateTime.Now);

//                minDay = persianDate.Day;
//                minMounth = persianDate.Month;
//                minYeaer = persianDate.Year;

//                yearLabel.Text = minYeaer.ToString();
//                dayLabel.Text = minDay.ToString();

//                mounthLabel.Text = Infrastructure.MountChange.numbertoname(minMounth);

//                date = minYeaer + "/" + minMounth + "/" + minDay;
//            }

//            #endregion /Calender Function

//            #region Change Public Field/Event Function
//            // پر کردن متغیر دکتر که مقدار آی دی دکتری که در جستجو انتخاب شده است
//            public void CreateDoctor()
//            {
//                doctor = Infrastructure.Utility.SelectDoctor.Id.ToString();
//            }

//            //پر کردن مقادیر چک باکس و تکس باکس با توجه به مقادیر دیتابیس 
//            public void VisitChanging(System.Windows.Forms.TextBox timeTextBox, System.Windows.Forms.CheckBox timeCheckBox,
//                string patientsName)
//            {
//                if (patientsName == string.Empty || patientsName == "حضور ندارند")
//                {
//                    timeTextBox.Enabled = false;

//                    timeTextBox.Text = "حضور ندارند";

//                    timeTextBox.BackColor = System.Drawing.Color.Red;

//                    timeTextBox.ForeColor = System.Drawing.Color.Black;

//                    timeCheckBox.Enabled = true;

//                    timeCheckBox.Checked = false;
//                }
//                else
//                {
//                    if (patientsName == "حضور دارند")
//                    {
//                        timeTextBox.Enabled = true;

//                        timeTextBox.Text = patientsName;

//                        timeTextBox.BackColor = System.Drawing.Color.Khaki;

//                        timeTextBox.ForeColor = System.Drawing.Color.Green;

//                        timeCheckBox.Enabled = true;

//                        timeCheckBox.Checked = true;
//                    }
//                    else
//                    {
//                        timeTextBox.Enabled = false;

//                        timeTextBox.Text = patientsName;

//                        timeTextBox.BackColor = System.Drawing.Color.Green;

//                        timeTextBox.ForeColor = System.Drawing.Color.White;

//                        timeCheckBox.Enabled = false;

//                        timeCheckBox.Checked = true;
//                    }
//                }

//            }

//            //مقدار جستجو شده را به تک تک تکس باکس ها اعمال میکند
//            public void CheckTime(Models.Reservations foundedUser)
//            {
//                VisitChanging(time8TextBox, time8checkBox, foundedUser.Time8);
//                VisitChanging(time9TextBox, time9checkBox, foundedUser.Time9);
//                VisitChanging(time10TextBox, time10checkBox, foundedUser.Time10);
//                VisitChanging(time11TextBox, time11checkBox, foundedUser.Time11);
//                VisitChanging(time12TextBox, time12checkBox, foundedUser.Time12);
//                VisitChanging(time13TextBox, time13checkBox, foundedUser.Time13);
//                VisitChanging(time14TextBox, time14checkBox, foundedUser.Time14);
//                VisitChanging(time15TextBox, time15checkBox, foundedUser.Time15);
//                VisitChanging(time16TextBox, time16checkBox, foundedUser.Time16);
//                VisitChanging(time17TextBox, time17checkBox, foundedUser.Time17);
//                VisitChanging(time18TextBox, time18checkBox, foundedUser.Time18);
//                VisitChanging(time19TextBox, time19checkBox, foundedUser.Time19);
//                VisitChanging(time20TextBox, time20checkBox, foundedUser.Time20);
//                VisitChanging(time21TextBox, time21checkBox, foundedUser.Time21);
//            }

//            //پر کردن تمام  مقادیر تکس باکس ها و چک باکس ها زمانی که برای بار اول صفحه باز می شود یا تاریخ تغییر میکند
//            public void SetFirstTime(System.Windows.Forms.TextBox textBox, System.Windows.Forms.CheckBox checkBox)
//            {
//                textBox.Text = "حضور ندارند";

//                textBox.Enabled = false;

//                textBox.BackColor = System.Drawing.Color.Red;

//                textBox.ForeColor = System.Drawing.Color.Black;

//                checkBox.Enabled = true;

//                checkBox.Checked = false;
//            }

//            //پیدا کردن سطر مربوط به دکتر انتخاب شده در روز مشخص شده
//            public void CheckVisitTime()
//            {
//                Models.DatabaseContext databaseContext = null;

//                try
//                {
//                    databaseContext = new Models.DatabaseContext();


//                    Models.Reservations foundedDoctor =
//                        databaseContext.Reservation
//                        .Where(current => string.Compare(current.doctorId, doctor, true) == 0 &&
//                        string.Compare(current.DateVisit, date, true) == 0)
//                        .FirstOrDefault();

//                    if (foundedDoctor == null)
//                    {
//                        SetFirstTime(time8TextBox, time8checkBox);
//                        SetFirstTime(time9TextBox, time9checkBox);
//                        SetFirstTime(time10TextBox, time10checkBox);
//                        SetFirstTime(time11TextBox, time11checkBox);
//                        SetFirstTime(time12TextBox, time12checkBox);
//                        SetFirstTime(time13TextBox, time13checkBox);
//                        SetFirstTime(time14TextBox, time14checkBox);
//                        SetFirstTime(time15TextBox, time15checkBox);
//                        SetFirstTime(time16TextBox, time16checkBox);
//                        SetFirstTime(time17TextBox, time17checkBox);
//                        SetFirstTime(time18TextBox, time18checkBox);
//                        SetFirstTime(time19TextBox, time19checkBox);
//                        SetFirstTime(time20TextBox, time20checkBox);
//                        SetFirstTime(time21TextBox, time21checkBox);

//                        return;
//                    }

//                    VisitDateDoctor = foundedDoctor;

//                    CheckTime(foundedDoctor);

//                }
//                catch (System.Exception ex)
//                {
//                    System.Windows.Forms.MessageBox.Show(ex.Message);

//                    return;
//                }
//                finally
//                {
//                    if (databaseContext != null)
//                    {
//                        databaseContext.Dispose();

//                        databaseContext = null;
//                    }
//                }

//            }

//            // تغییراتی که هنگامی که چک باکس تغییر میکند باید تغییر داده شود
//            public void ChangeCheckBox(System.Windows.Forms.TextBox TextBox, System.Windows.Forms.CheckBox CheckBox)
//            {
//                if (CheckBox.Checked == true)
//                {
//                    TextBox.Enabled = true;

//                    TextBox.Text = "حضور دارند";

//                    TextBox.BackColor = System.Drawing.Color.Khaki;

//                    TextBox.ForeColor = System.Drawing.Color.Green;

//                }
//                else
//                {
//                    TextBox.Enabled = false;

//                    TextBox.Text = "حضور ندارند";

//                    TextBox.BackColor = System.Drawing.Color.Red;

//                    TextBox.ForeColor = System.Drawing.Color.Black;

//                }
//            }

//            //تمام مقادیر داخل تکس باکس ها را با مقدار اولیه که از دیتابیس فراخوانی شده بود مقایسه میکند و در صورت بروز 
//            // تغییر مقدار دیتابیس چینج را تغییر میدهد.
//            public void TestChangeDatabase()
//            {
//                #region if
//                if (VisitDateDoctor == null)
//                {
//                    if (time8TextBox.Text == "حضور ندارند" &&
//                    time9TextBox.Text == "حضور ندارند" &&
//                    time10TextBox.Text == "حضور ندارند" &&
//                    time11TextBox.Text == "حضور ندارند" &&
//                    time12TextBox.Text == "حضور ندارند" &&
//                    time13TextBox.Text == "حضور ندارند" &&
//                    time14TextBox.Text == "حضور ندارند" &&
//                    time15TextBox.Text == "حضور ندارند" &&
//                    time16TextBox.Text == "حضور ندارند" &&
//                    time17TextBox.Text == "حضور ندارند" &&
//                    time18TextBox.Text == "حضور ندارند" &&
//                    time19TextBox.Text == "حضور ندارند" &&
//                    time20TextBox.Text == "حضور ندارند" &&
//                    time21TextBox.Text == "حضور ندارند")
//                    {
//                        DatabaseChange = false;

//                        return;
//                    }
//                }
//                #endregion/ if

//                #region else
//                else
//                {
//                    if (VisitDateDoctor.Time8 == time8TextBox.Text &&
//                   VisitDateDoctor.Time9 == time9TextBox.Text &&
//                   VisitDateDoctor.Time10 == time10TextBox.Text &&
//                   VisitDateDoctor.Time11 == time11TextBox.Text &&
//                   VisitDateDoctor.Time12 == time12TextBox.Text &&
//                   VisitDateDoctor.Time13 == time13TextBox.Text &&
//                   VisitDateDoctor.Time14 == time14TextBox.Text &&
//                   VisitDateDoctor.Time15 == time15TextBox.Text &&
//                   VisitDateDoctor.Time16 == time16TextBox.Text &&
//                   VisitDateDoctor.Time17 == time17TextBox.Text &&
//                   VisitDateDoctor.Time18 == time18TextBox.Text &&
//                   VisitDateDoctor.Time19 == time19TextBox.Text &&
//                   VisitDateDoctor.Time20 == time20TextBox.Text &&
//                   VisitDateDoctor.Time21 == time21TextBox.Text)
//                    {
//                        DatabaseChange = false;

//                        return;
//                    }
//                }
//                #endregion/else

//                DatabaseChange = true;

//                return;
//            }

//            public void SearchLeaveTextBox(System.Windows.Forms.TextBox TextBox)
//            {
//                Models.Patients SelectPatient;

//                Models.DatabaseContext databaseContext = null;

//                try
//                {
//                    databaseContext = new Models.DatabaseContext();

//                    System.Collections.Generic.List<Models.Patients> Patient = null;

//                    Patient =
//                        databaseContext.Patient
//                        .Where(current => current.FirstName.Contains(TextBox.Text))
//                        .OrderBy(current => current.FirstName)
//                        .ToList();

//                    if (Patient.Count == 0)
//                    {
//                        Patient =
//                            databaseContext.Patient
//                            .Where(current => current.LastName.Contains(TextBox.Text))
//                            .OrderBy(current => current.LastName)
//                            .ToList();

//                        if (Patient.Count == 0)
//                        {
//                            Patient =
//                                 databaseContext.Patient
//                                 .Where(current => current.Mobile.Contains(TextBox.Text))
//                                 .OrderBy(current => current.Mobile)
//                                 .ToList();

//                            if (Patient.Count == 0)
//                            {
//                                Patient =
//                                    databaseContext.Patient
//                                    .Where(current => current.Phone.Contains(TextBox.Text))
//                                    .OrderBy(current => current.Phone)
//                                    .ToList();
//                                if (Patient.Count == 0)
//                                {
//                                    System.Windows.Forms.MessageBox.Show("بیماری با این مشخصات وجود ندارد لطفاً ابتدا اطلاعات بیمار را وارد کنید");

//                                    TextBox.Text = "حضور دارند";

//                                    return;
//                                }
//                            }
//                        }
//                    }

//                    //SelectPatientForm form = new SelectPatientForm();

//                    //form.DataSet = Patient;

//                    //form.ShowDialog();

//                    //SelectPatient = form.SelectPatients;

//                    //TextBox.Text = SelectPatient.DisplayName;
//                }
//                catch (System.Exception ex)
//                {
//                    System.Windows.Forms.MessageBox.Show(ex.Message);

//                    return;
//                }
//                finally
//                {
//                    if (databaseContext != null)
//                    {
//                        databaseContext.Dispose();

//                        databaseContext = null;
//                    }
//                }
//            }

//            #endregion / Change Public Field/Event Function

//            private void attendance_Load(object sender, System.EventArgs e)
//            {
//                doctorNameLabel.Text = Infrastructure.Utility.SelectDoctor.DisplayName;

//                CreateDoctor();

//                CreateDate();

//                CheckVisitTime();

//            }

//            #region calender code
//            private void nextYearButton_Click(object sender, System.EventArgs e)
//            {
//                priviosYearButton.Enabled = true;

//                int year;

//                year = System.Convert.ToInt32(yearLabel.Text);

//                year++;

//                yearLabel.Text = year.ToString();

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();
//            }

//            private void priviosYearButton_Click(object sender, System.EventArgs e)
//            {
//                int year;

//                year = System.Convert.ToInt32(yearLabel.Text);

//                year--;

//                string result =
//                    checkchange(dayLabel.Text, mounthLabel.Text, year.ToString());
//                if (result != "Ok")
//                {
//                    priviosYearButton.Enabled = false;
//                    return;
//                }
//                yearLabel.Text = year.ToString();

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();

//            }

//            private void nextDayButton_Click(object sender, System.EventArgs e)
//            {
//                priviosDayButton.Enabled = true;

//                int day;

//                day = System.Convert.ToInt32(dayLabel.Text);

//                if (day > 29)
//                {
//                    if (mounthLabel.Text == "فروردین" ||
//                        mounthLabel.Text == "اردیبهشت" ||
//                        mounthLabel.Text == "خرداد" ||
//                        mounthLabel.Text == "تیر" ||
//                        mounthLabel.Text == "مرداد" ||
//                        mounthLabel.Text == "شهریور")
//                    {
//                        if (day == 31)
//                        {
//                            day = 1;

//                            dayLabel.Text = day.ToString();

//                            date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                            CheckVisitTime();

//                            return;
//                        }
//                        day++;

//                        dayLabel.Text = day.ToString();

//                        date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                        CheckVisitTime();

//                        return;
//                    }

//                    day = 1;

//                    dayLabel.Text = day.ToString();

//                    date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                    CheckVisitTime();

//                    return;
//                }

//                day++;

//                dayLabel.Text = day.ToString();

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();
//            }

//            private void priviosDayButton_Click(object sender, System.EventArgs e)
//            {
//                int day;

//                day = System.Convert.ToInt32(dayLabel.Text);

//                if (day == 1)
//                {
//                    if (mounthLabel.Text == "فروردین" ||
//                        mounthLabel.Text == "اردیبهشت" ||
//                        mounthLabel.Text == "خرداد" ||
//                        mounthLabel.Text == "تیر" ||
//                        mounthLabel.Text == "مرداد" ||
//                        mounthLabel.Text == "شهریور")
//                    {
//                        day = 31;

//                        dayLabel.Text = day.ToString();

//                        date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                        CheckVisitTime();

//                        return;
//                    }
//                    day = 30;

//                    dayLabel.Text = day.ToString();

//                    date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                    CheckVisitTime();

//                    return;
//                }

//                day--;

//                string result =
//                    checkchange(day.ToString(), mounthLabel.Text, yearLabel.Text);

//                if (result != "Ok")
//                {
//                    priviosDayButton.Enabled = false;

//                    return;
//                }

//                dayLabel.Text = day.ToString();

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();

//                return;
//            }

//            private void nextMounthButton_Click(object sender, System.EventArgs e)
//            {
//                priviosMountButton.Enabled = true;

//                mounthLabel.Text = Infrastructure.MountChange.nextmountname(mounthLabel.Text);

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();
//            }

//            private void priviosMountButton_Click(object sender, System.EventArgs e)
//            {
//                string mounth = string.Empty;

//                mounth = Infrastructure.MountChange.previousmountname(mounthLabel.Text);

//                string result =
//                    checkchange(dayLabel.Text, mounth, yearLabel.Text);

//                if (result != "Ok")
//                {
//                    priviosMountButton.Enabled = false;

//                    return;
//                }

//                mounthLabel.Text = mounth;

//                date = yearLabel.Text + "/" + Infrastructure.MountChange.nametonumber(mounthLabel.Text) + "/" + dayLabel.Text;

//                CheckVisitTime();
//            }
//            #endregion / calender code

//            private void exitButton_Click(object sender, System.EventArgs e)
//            {
//                Close();
//            }

//            #region CheckBox Code
//            private void time8checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time8TextBox, time8checkBox);
//            }

//            private void time9checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time9TextBox, time9checkBox);
//            }

//            private void time10checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time10TextBox, time10checkBox);
//            }

//            private void time11checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time11TextBox, time11checkBox);
//            }

//            private void time12checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time12TextBox, time12checkBox);
//            }

//            private void time13checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time13TextBox, time13checkBox);
//            }

//            private void time14checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time14TextBox, time14checkBox);
//            }

//            private void time15checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time15TextBox, time15checkBox);
//            }

//            private void time16checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time16TextBox, time16checkBox);
//            }

//            private void time17checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time17TextBox, time17checkBox);
//            }

//            private void time18checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time18TextBox, time18checkBox);
//            }

//            private void time19checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time19TextBox, time19checkBox);
//            }

//            private void time20checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time20TextBox, time20checkBox);
//            }

//            private void time21checkBox_CheckedChanged(object sender, System.EventArgs e)
//            {
//                ChangeCheckBox(time21TextBox, time21checkBox);
//            }

//            #endregion/ CheckBox Code

//            private void saveButton_Click(object sender, System.EventArgs e)
//            {
//                TestChangeDatabase();

//                if (DatabaseChange == true)
//                {
//                    Models.DatabaseContext databaseContext = null;
//                    try
//                    {
//                        databaseContext = new Models.DatabaseContext();

//                        if (VisitDateDoctor != null)
//                        {
//                            Models.Reservations currentVisit =
//                                                databaseContext.Reservation
//                                                .Where(current => current.Id == VisitDateDoctor.Id)
//                                                .FirstOrDefault();

//                            if (currentVisit == null)
//                            {
//                                System.Windows.Forms.Application.Exit();
//                            }

//                            currentVisit.Time8 = time8TextBox.Text;
//                            currentVisit.Time9 = time9TextBox.Text;
//                            currentVisit.Time10 = time10TextBox.Text;
//                            currentVisit.Time11 = time11TextBox.Text;
//                            currentVisit.Time12 = time12TextBox.Text;
//                            currentVisit.Time13 = time13TextBox.Text;
//                            currentVisit.Time14 = time14TextBox.Text;
//                            currentVisit.Time15 = time15TextBox.Text;
//                            currentVisit.Time16 = time16TextBox.Text;
//                            currentVisit.Time17 = time17TextBox.Text;
//                            currentVisit.Time18 = time18TextBox.Text;
//                            currentVisit.Time19 = time19TextBox.Text;
//                            currentVisit.Time20 = time20TextBox.Text;
//                            currentVisit.Time21 = time21TextBox.Text;

//                            databaseContext.SaveChanges();

//                            System.Windows.Forms.MessageBox.Show("ذخیره سازی با موفقیت انجام شد.");

//                            return;
//                        }

//                        Models.Reservations AddDateVisit = new Models.Reservations
//                        {
//                            DateVisit = date,
//                            doctorId = doctor,
//                            Time8 = time8TextBox.Text,
//                            Time9 = time9TextBox.Text,
//                            Time10 = time10TextBox.Text,
//                            Time11 = time11TextBox.Text,
//                            Time12 = time12TextBox.Text,
//                            Time13 = time13TextBox.Text,
//                            Time14 = time14TextBox.Text,
//                            Time15 = time15TextBox.Text,
//                            Time16 = time16TextBox.Text,
//                            Time17 = time17TextBox.Text,
//                            Time18 = time18TextBox.Text,
//                            Time19 = time19TextBox.Text,
//                            Time20 = time20TextBox.Text,
//                            Time21 = time21TextBox.Text
//                        };

//                        databaseContext.Reservation.Add(AddDateVisit);

//                        databaseContext.SaveChanges();

//                        System.Windows.Forms.MessageBox.Show("ذخیره سازی با موفقیت انجام شد.");

//                        return;
//                    }
//                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
//                    {
//                        foreach (var eve in ex.EntityValidationErrors)
//                        {
//                            System.Windows.Forms.MessageBox.Show($"Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
//                                eve.Entry.Entity.GetType().Name);
//                            foreach (var ve in eve.ValidationErrors)
//                            {
//                                System.Windows.Forms.MessageBox.Show($"- Property: \"{0}\", Error: \"{1}\"",
//                                    ve.PropertyName);
//                            }
//                        }
//                        return;
//                    }
//                    finally
//                    {
//                        if (databaseContext != null)
//                        {
//                            databaseContext.Dispose();

//                            databaseContext = null;
//                        }
//                    }
//                }

//                System.Windows.Forms.MessageBox.Show("تغییری رخ نداده است ؟");
//            }

//            private void time8TextBox_Leave(object sender, System.EventArgs e)
//            {
//                SearchLeaveTextBox(time8TextBox);
//            }

//            private void time9TextBox_Leave(object sender, System.EventArgs e)
//            {

//                SearchLeaveTextBox(time9TextBox);
//            }
//        }
//    }

}
}
