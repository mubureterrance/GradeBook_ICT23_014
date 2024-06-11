using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Data;
using System.Dynamic;

namespace GradeBook_ICT23_014
{
    internal class DataAcces
    {
        //get system title
        public String GetSystemTitle()
        {
            return "SCIS GRADEBOOK";
        }

        //Capitalise each 1st letter of a string
        public string CapitalisePhrase(string phrase)
        {
            string[] arr = phrase.ToLower().Split(' ');
            string newPhrase = "";
            foreach (string word in arr)
            {
                newPhrase += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            }
            return newPhrase;
        }

        //save file data
        public int SaveData(String filepath, String[] Columns, String[] arrdata)
        {
            try
            {
                //check if .txt file extension is missing and add to filename
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; 

                String columndata = string.Join("#", Columns);
                String linedata = string.Join("#", arrdata);

                //check if ColumnHeaders Exist, if new file, add headers first
                bool NoHeaderExists = false;
                try
                {
                    using (StreamReader sr = new StreamReader(filepath)) { String? Line1 = sr.ReadLine(); NoHeaderExists = String.IsNullOrEmpty(Line1); sr.Close(); sr.Dispose(); }
                }
                catch (Exception ex) { NoHeaderExists = true; }

                //create file stream for writing, and set properties, if file exists append, if not create and add data
                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate | FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    if (NoHeaderExists) { sw.WriteLine(columndata); }
                    sw.WriteLine(linedata);
                    sw.Flush();
                    fs.Flush();
                    sw.Close(); //no longer necessary because of | using
                    fs.Close(); //no longer necessary because of | using
                }

                return 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OverWriteFile(String filepath, String[] Columns, String[] arrdata)
        {
            //method over write a file, if file doesn't exist method will create a new file
            try
            {
                //check if .txt file extension is missing and add to filename
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt";

                String columndata = string.Join("#", Columns);
                String linedata = string.Join("#", arrdata);

                //check if ColumnHeaders Exist, if new file, add headers first
                bool NoHeaderExists = false;
                try
                {
                    using (StreamReader sr = new StreamReader(filepath)) { String? Line1 = sr.ReadLine(); NoHeaderExists = String.IsNullOrEmpty(Line1); sr.Close(); sr.Dispose(); }
                }
                catch (Exception ex) { NoHeaderExists = true; }

                //create file stream for writing, and set properties, if file exists append, if not create and add data
                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    if (NoHeaderExists) { sw.WriteLine(columndata); }
                    sw.WriteLine(linedata);
                    sw.Flush();
                    fs.Flush();
                    sw.Close(); //no longer necessary because of | using
                    fs.Close(); //no longer necessary because of | using
                }

                return 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
        //read tabledata | JAGGED Array
        public List<dynamic> ReadFileData(String filepath)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                List<String> filedata = File.ReadAllLines(filepath).Skip(1).ToList<String>(); //skip column headers
                int colcount = filedata[0].Split("#").Length;
                List<dynamic> listdata = new List<dynamic>();
                for (int k = 0; k < filedata.Count(); k++)
                {
                    String line = filedata[k];
                    String[] linedata = line.Split("#");
                    listdata.Add(linedata);
                }
                return listdata;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //read tabledata | Data Table
        public DataTable ReadFileDataTable(String filepath, bool ThrowFileNotFoundException = true)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                String filename = filepath.Substring(0, filepath.IndexOf(".")).ToLower();

                //is file existing
                if (!File.Exists(filepath))
                {
                    if (ThrowFileNotFoundException == false) { return new DataTable(); }
                    throw new Exception("File not found, please verify the file exists !!");
                }

                List<String> filedata = File.ReadAllLines(filepath).ToList<String>(); //include column headers
                String[] columns = filedata[0].Split("#");
                int colcount = columns.Length;

                //create datatable
                DataTable dt = new DataTable(filename);
                dt.Columns.AddRange(columns.Select(col => new DataColumn(col)).ToArray()); //one liner
                //for (int x = 0; x < colcount; x++)
                //{
                //    dt.Columns.Add(new DataColumn(columns[x]));
                //}
                for (int k = 1; k < filedata.Count(); k++)
                {
                    String line = filedata[k];
                    String[] linedata = line.Split("#");
                    dt.Rows.Add(linedata);
                }
                //remove column if needed
                //dt.Columns.Remove("COLUMN_4");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateFileRecord(String filepath, String[] arrdata, int KeyColumnPosition = 0)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                String linedata = string.Join("#", arrdata);

                //get file data and search record to update
                //is file existing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get desired record index
                List<String> FileData = File.ReadAllLines(filepath).ToList(); //include column headers
                var recordindex = FileData.Select((row, index) => new { row, index })
                                          .FirstOrDefault(x => x.row.Split('#')[KeyColumnPosition] == arrdata[KeyColumnPosition])?.index ?? -1;
                var recordindex1 = FileData.FindIndex(row => row.Split('#')[KeyColumnPosition] == arrdata[KeyColumnPosition]);

                //replaceFileData[recordindex] with new line | update process
                FileData[recordindex] = linedata;

                //update whole file
                File.WriteAllLines(filepath, FileData);

                //return value on success
                return 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //delete file record
        public int DeleteFileRecord(String filepath, String RecordKeyValue, int KeyColumnPosition = 0)
        {
            try
            {

                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //is file existing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get desired record index
                List<String> FileData = File.ReadAllLines(filepath).ToList(); //include column headers
                var recordindex = FileData.Select((row, index) => new { row, index })
                                          .FirstOrDefault(x => x.row.Split('#')[KeyColumnPosition] == RecordKeyValue)?.index ?? -1;
                var recordindex1 = FileData.FindIndex(row => row.Split('#')[KeyColumnPosition] == RecordKeyValue);

                //replaceFileData[recordindex] with new line | delete process
                ArrayList arrlist = new ArrayList(FileData);
                arrlist.RemoveAt(recordindex);
                String[] NewFileData = new String[arrlist.Count]; //dimension array to match arrlist size
                arrlist.CopyTo(NewFileData); //delete with arraylist, then convert to array
                //FileData = (String[])arrlist.ToArray(typeof(string)); //alternative to_array

                //update whole file
                File.WriteAllLines(filepath, NewFileData);

                //return value on success
                return 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //is record existing, check if key exists, based on chosen key column position
        public bool IsRecordExisting(String filepath, String RecordKeyValue, int KeyColumnPosition = 0)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //is file existing
                if (!File.Exists(filepath))
                {
                    return false;
                }
                //search desired record index
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var recordindex = FileData.Select((row, index) => new { row, index })
                                          .FirstOrDefault(x => x.row.Split('#')[KeyColumnPosition] == RecordKeyValue)?.index ?? -1;
                var recordindex1 = FileData.FindIndex(row => row.Split('#')[KeyColumnPosition] == RecordKeyValue);

                //if index = -1 | not found => False ELSE True
                return (recordindex == -1) ? false : true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //search file record, based on chosen key column position
        public String[] SearchFileRecord(String filepath, String RecordKeyValue, int KeyColumnPosition = 0)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //default empty array return string if nothing found
                String[] arrrecord = new String[] { };

                //is file existing
                if (!File.Exists(filepath))
                {
                    return arrrecord;
                }
                //search desired record index
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var recordindex = FileData.Select((row, index) => new { row, index })
                                          .FirstOrDefault(x => x.row.Split('#')[KeyColumnPosition] == RecordKeyValue)?.index ?? -1;
                var recordindex1 = FileData.FindIndex(row => row.Split('#')[KeyColumnPosition] == RecordKeyValue);

                //if index = -1 | not found => False ELSE True
                return (recordindex >= 0) ? FileData[recordindex].Split('#') : arrrecord;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //search file record, based on chosen key column position
        public String[] AuthenticateUser(String filepath,
                                         String UsernameValue, String PasswordValue,
                                         int UsernameColumPosition = 0, int PasswordColumnPosition = 1)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //default empty array return string if nothing found
                String[] arrrecord = new String[] { };

                //is file existing
                if (!File.Exists(filepath))
                {
                    return arrrecord;
                }
                //search desired record index
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var recordindex = FileData.Select((row, index) => new { row, index })
                                          .FirstOrDefault(x => x.row.Split('#')[UsernameColumPosition] == UsernameValue &&
                                          x.row.Split('#')[PasswordColumnPosition] == PasswordValue)?.index ?? -1;
                var recordindex1 = FileData.FindIndex(row => row.Split('#')[UsernameColumPosition] == UsernameValue && row.Split('#')[PasswordColumnPosition] == PasswordValue);

                //if index = -1 | not found => False ELSE True
                return (recordindex >= 0) ? FileData[recordindex].Split('#') : arrrecord;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //get current record id - auto generated keys
        public int GetCurrentID(string filepath, int incrementBy = 1, int initialValue = 1)
        {
            try
            {
                int CurrentID = 0;
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                if (File.Exists(filepath))
                {
                    List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList(); //skip column headers
                    var fd = (from line in FileData
                              let linedata = line.Split('#')
                              let ID_FIELD = linedata[0]
                              orderby ID_FIELD descending
                              select new { ID_FIELD }).ToList();

                    //check if found
                    if (fd.Count == 0)
                    {
                        CurrentID = initialValue;
                    }
                    else
                    {
                        CurrentID = Convert.ToInt32(fd[0].ID_FIELD);
                        CurrentID += incrementBy;
                    }
                }
                else
                {
                    CurrentID = initialValue;
                }
                return CurrentID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //method to clear recursively form controls
        public void ClearFormControls(Form frm)
        {
            try
            {

                foreach (Control ctl in frm.Controls)
                {
                    if (ctl is GroupBox || ctl is Panel)
                    {
                        HandleGroupBoxOrPanel(ctl);
                    }
                    else
                    {
                        ClearControl(ctl);
                    }
                }
                void HandleGroupBoxOrPanel(Control GrbOrPnl)
                {
                    foreach (Control ctl in GrbOrPnl.Controls)
                    {
                        if (ctl is GroupBox || ctl is Panel)
                        {
                            HandleGroupBoxOrPanel(ctl);
                        }
                        else
                        {
                            ClearControl(ctl);
                        }
                    }
                }
                void ClearControl(Control ctl)
                {
                    if (ctl is TextBox)
                    {
                        ((TextBox)ctl).Clear();
                    }
                    else if (ctl is ComboBox)
                    {
                        ((ComboBox)ctl).SelectedIndex = -1;
                    }
                    else if (ctl is DateTimePicker)
                    {
                        ((DateTimePicker)ctl).Value = DateTime.Now;
                    }
                    else if (ctl is CheckBox)
                    {
                        ((CheckBox)ctl).Checked = false;
                    }
                    else if (ctl is RadioButton)
                    {
                        ((RadioButton)ctl).Checked = false;
                    }
                    else if (ctl is DataGridView)
                    {
                        //((DataGridView)ctl).DataSource = null;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// end clear form controls

        //load combobox from array
        public void LoadDropDown(ComboBox cbo, DataTable dt, String KeyColumn = "", String DisplayColumn = "")
        {
            try
            {
                //load dropdown
                cbo.DataSource = dt;
                //set column properties
                cbo.ValueMember = String.IsNullOrEmpty(KeyColumn.Trim()) ? dt.Columns[0].ColumnName : KeyColumn;
                cbo.DisplayMember = String.IsNullOrEmpty(DisplayColumn.Trim()) ? dt.Columns[0].ColumnName : DisplayColumn;
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //loadcombo data | great work with DYNAMIC
        public void LoadDropDown(ComboBox cbo, String? filepath = null, String[]? arrdata = null, List<dynamic>? listdata = null, Dictionary<String, String>? dictdata = null)
        {
            try
            {

                if (!String.IsNullOrEmpty(filepath))
                { //get listdata from file
                    //is file existing
                    filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                    if (!File.Exists(filepath)) { throw new Exception("File not found, please verify the file exists !!"); }

                    //get file data 
                    List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                    var fd = (from line in FileData
                              let linedata = line.Split('#')
                              let ValueIndex = (linedata.Length == 1) ? 0 : 1 //fixes 1 col files
                              let KeyField = linedata[0]
                              let DisplayField = linedata[ValueIndex]
                              orderby KeyField ascending
                              select new { KeyField, DisplayField }
                        ).ToList();

                    //syncronise
                    listdata = fd.ToList<dynamic>();

                }
                else if (arrdata != null)
                {  //get listdata from array
                    listdata = new List<dynamic>(arrdata);

                }
                else if (listdata != null)
                { //if dynamic list supplied
                    listdata = new List<dynamic>(listdata);

                }
                else if (dictdata != null)
                { //if dictdata is supplied, syncronise with list
                    listdata = (from line in dictdata
                                select new { KeyField = line.Key, DisplayField = line.Value }
                               ).ToList<dynamic>();
                }

                //customise list to standard cols
                var combodata = (from line in listdata
                                 let props = line.GetType().GetProperties()   //get dynamic props through Reflection for indexing below
                                 let ValueIndex = (props.Length == 1) ? 0 : 1 //fixes 1 col files
                                 select new { KeyField = props[0].GetValue(line), DisplayField = props[ValueIndex].GetValue(line) }
                               ).ToList<dynamic>();

                //load dropdown
                cbo.DataSource = combodata.ToList();
                cbo.ValueMember = "KeyField";
                cbo.DisplayMember = "DisplayField";
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadGridData(DataGridView grid, List<dynamic>? listdata = null, DataTable? dt = null)
        {
            try
            {
                //
                if (listdata is not null)
                {
                    grid.DataSource = listdata; //list supplied
                }
                else
                {
                    grid.DataSource = dt; //dt supplied

                }

                //format
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToResizeRows = false;
                grid.RowHeadersWidth = 15;
                grid.BackgroundColor = System.Drawing.Color.Honeydew;
                grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Ivory;
                grid.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;
                grid.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Ivory;
                grid.ForeColor = System.Drawing.Color.Blue;
                grid.MultiSelect = false;
                grid.ClearSelection(); //-remove default selection of first row-
                //
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //get staff details for report
        public List<dynamic> GetStaffDetails(String filepath)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //is file existing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get data 
                List<String> FileData = File.ReadAllLines (filepath).Skip(1).ToList();
                var fd = (from line in FileData
                          let linedata = line.Split('#')
                          let STAFF_ID = linedata[0]
                          let EMAIL = linedata[1]
                          let Password = linedata[2]
                          let FIRSTNAME = linedata[3]
                          let SURNAME = linedata[4]
                          let Gender = linedata[5]
                          let TITLE = (Gender == "Female") ? "Mrs" : "Mr"
                          let CONTACT = linedata[6]
                          let POSITION = linedata[7]
                          let DATE_REGISTERED = linedata[8]
                          orderby STAFF_ID ascending
                          select new { STAFF_ID, TITLE, FIRSTNAME, SURNAME, EMAIL, CONTACT, POSITION, DATE_REGISTERED }
                    ).ToList();

                return fd.ToList<dynamic>();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get staff details for report
        public List<dynamic> GetStudentDetails(String filepath)
        {
            try
            {
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                //is file existing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get data STUDENT_ID#FIRSTNAME#SURNAME#GENDER#DOB#PHONE#PROGRAM#LEVEL#MODULE
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var fd = (from line in FileData
                          let linedata = line.Split('#')
                          let STUDENT_ID = linedata[0]
                          let FIRSTNAME = linedata[1]
                          let LASTNAME = linedata[2]
                          let GENDER = linedata[3]
                          let DATE_OF_BIRTH = linedata[4]
                          let CONTACT = linedata[5]
                          let TITLE = (GENDER == "Female") ? "Mrs" : "Mr"
                          let PROGRAME = linedata[6]
                          let LEVEL = linedata[7]
                          let MODULE = linedata[8]
                          orderby STUDENT_ID ascending
                          select new { STUDENT_ID, TITLE, FIRSTNAME, LASTNAME, DATE_OF_BIRTH, CONTACT, PROGRAME, LEVEL, MODULE }
                    ).ToList();

                return fd.ToList<dynamic>();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get assessment model list data
        public List<dynamic> GetAssessmentModel(String filepath)
        {
            try
            {
                //is file existing
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get data 
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var fd = (from line in FileData
                          let linedata = line.Split('#')
                          let AssessmentTest = Convert.ToInt32(linedata[0])
                          let Assignment = Convert.ToInt32(linedata[1])
                          let CourseWork = Convert.ToInt32(linedata[2])
                          let FinalExam = Convert.ToInt32(linedata[3])
                          orderby AssessmentTest ascending
                          select new { AssessmentTest, Assignment, CourseWork, FinalExam }
                    ).ToList();

                return fd.ToList<dynamic>();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get grading criteria list data
        public List<dynamic> GetGradingCriteria(String filepath)
        {
            try
            {
                //is file existing
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get data 
                List<String> FileData = File.ReadAllLines(filepath).Skip(1).ToList();
                var fd = (from line in FileData
                          let linedata = line.Split('#')
                          let GRADE_ID = Convert.ToString(linedata[0])
                          let DATE_RECORDED = Convert.ToDateTime(linedata[1])
                          let MARK_FROM = Convert.ToInt32(linedata[2])
                          let MARK_TO = Convert.ToInt32(linedata[3])
                          let GRADE = Convert.ToString(linedata[4])
                          orderby GRADE_ID ascending
                          select new { MARK_FROM, MARK_TO, GRADE }
                    ).ToList();

                return fd.ToList<dynamic>();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public List<dynamic> GetStudentMarksDetails()
        {
            try
            {
                //is file existing
                String filepath = "students.txt";
                filepath = filepath.Trim().EndsWith(".txt") ? filepath : filepath.Trim() + ".txt"; //add extension is missing
                if (!File.Exists(filepath))
                {
                    throw new Exception("File not found, please verify the file exists !!");
                }
                //get data  STUDENT_ID#FIRSTNAME#SURNAME#GENDER#D.O.B#PHONE#PROGRAM#LEVEL#MODULE
                List<String> StudentsData = File.ReadAllLines(filepath).Skip(1).ToList();
                var sd = (from student in StudentsData
                          let linedata = student.Split('#')
                          let STUDENT_ID = linedata[0]
                          let FIRSTNAME = linedata[1]
                          let SURNAME = linedata[2]
                          let GENDER = linedata[3]
                          let DOB = linedata[4]
                          let PHONE = linedata[5]
                          let PROGRAM = linedata[6]
                          let LEVEL = linedata[7]
                          let MODULE = linedata[8]
                          let Title = (GENDER.ToUpper() == "FEMALE") ? "Ms. " : "Mr. "
                          let FULLNAME = $"{FIRSTNAME} {SURNAME}"
                          orderby STUDENT_ID ascending
                          select new { STUDENT_ID, Title, FULLNAME}
                    ).ToList();

                //STUDENT_ID#MODULE#ASSESSMENT_TEST#ASSIGNMENT#FINAL_EXAM#MODULE_MARK#GRADE#DATE_RECORDED#STAFF_ID
                List<String> MarksData = File.ReadAllLines("marks.txt").Skip(1).ToList();
                var td = (from mark in MarksData
                          let linedata = mark.Split('#')
                          let STUDENT_ID = linedata[0]
                          let MODULE = linedata[1]
                          let ASSESSMENT_TEST = linedata[2]
                          let ASSIGNMENT = linedata[3]
                          let FINAL_EXAM = linedata[4]
                          let MODULE_MARK = linedata[5]
                          let GRADE = linedata[6]
                          let DATE_RECORDED = linedata[7]
                          let STAFF_ID = linedata[8]
                          orderby STUDENT_ID ascending
                          select new { STUDENT_ID, MODULE, ASSESSMENT_TEST, ASSIGNMENT, FINAL_EXAM, MODULE_MARK, GRADE }
                    ).ToList();

                //join query
                var fd =
                   from studentrow in sd
                   join markrow in td on studentrow.STUDENT_ID equals markrow.STUDENT_ID
                   where studentrow.STUDENT_ID != ""
                   orderby studentrow.STUDENT_ID ascending
                   select new { studentrow.STUDENT_ID, studentrow.Title, studentrow.FULLNAME, markrow.MODULE, markrow.ASSESSMENT_TEST, markrow.ASSIGNMENT, markrow.FINAL_EXAM, markrow.MODULE_MARK, markrow.GRADE };

                //return
                return fd.ToList<dynamic>();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] ReadFileText(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"[{filePath}] file doesn's exist");
                }
                //Read all text in a file and store as a string
                string dataFile = File.ReadAllText(filePath);

                //split the string into a array 
                string[] values = dataFile.Split('#');
                return values;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
