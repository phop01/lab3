namespace lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<data_student> liststudent = new List<data_student>();
        data_student student_DATA;

        string id_student;
        string name_student;
        double score_student;
        
        int arr_index = 0;
        string[] arrid = new string[1000];
        string[] arrname = new string[1000];
        int[] arrscore = new int[1000];

       
        int[] c_score = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_idx, max_value, min_value, min_idx;
         
        double[] all_grade = new double[8];
        double[] gpa = {4.0,3.5,3.0,2.5,2.0,1.5,1.0 };

        int[] n_grade = new int[8];

        private void save_button_Click(object sender, EventArgs e)
        {
            id_student = text_id_student.Text;
            name_student = text_name.Text;
            score_student = double.Parse(text_point.Text);

            data_student student = new data_student();
            student.student = id_student;
            student.name = name_student;
            student.score = score_student;

            liststudent.Add(student);


            arr_index++;
            text_name.Text = "";
            text_id_student.Text = "";
            text_point.Text = string.Empty;

            double max= 0;
            foreach (data_student item in liststudent)
            {

                if (item.score > max)
                {
                    max = item.score;
                    student_max.Text = item.student;
                    name_max.Text = item.name;
                    socre_max.Text= item.score.ToString();

                }

            }

            double min = max;
            foreach (data_student item in liststudent)
            {
                min = item.score;
                student_min.Text = item.student;
                name_min.Text = item.name;
                socre_min.Text= item.score.ToString();
            }

            double sum_lis = (double)liststudent.Sum(MIMX => MIMX.score);
            avg_point.Text = (sum_lis / (double)liststudent.Count).ToString("0.0");

            double cu_point = score_student;
            if (cu_point >= 80 && cu_point <= 100) 
            {
                //A
                n_grade[0]++;
                all_grade[0] = (n_grade[0] * gpa[0]);
                textBox_A.Text = n_grade[0].ToString();

            }
            else if (cu_point >= 75 && cu_point <= 79) 
            {
                n_grade[1]++;
                all_grade[1] = (n_grade[1] * gpa[1]);
                textBox_B_pass.Text = n_grade[1].ToString();
            }
            else if (cu_point >= 70 && cu_point <= 74) 
            {
                n_grade[2]++;
                all_grade[2] = (n_grade[2] * gpa[2]);
                textBox_B.Text = n_grade[2].ToString();
            }
            else if (cu_point >= 65 && cu_point <= 69)
            {
                n_grade[3]++;
                all_grade[3] = (n_grade[3] * gpa[3]);
                textBox_C_pass.Text= n_grade[3].ToString();
            }
            else if (cu_point >= 60 && cu_point <= 64)
            {
                n_grade[4]++;
                all_grade[4] = (n_grade[4] * gpa[4]);
                textBox_C.Text = n_grade[4].ToString();
            }
            else if (cu_point >= 55 && cu_point <= 69)
            {
                n_grade[5]++;
                all_grade[5] = (n_grade[5] * gpa[5]);
                textBox_D_pass.Text = n_grade[5].ToString();
            }
            else if (cu_point >= 50 && cu_point <= 54)
            {
                n_grade[6]++;
                all_grade[6] = (n_grade[6] * gpa[6]);
                textBox_D.Text = n_grade[6].ToString();
            }
            else 
            {
                n_grade[7]++;
                textBox_F.Text = n_grade[7].ToString();
            }
            double ga = 0.0;
            for (int i = 0; i < n_grade.Length; i++)
            {
                ga += all_grade[i]; 
            }
            //??????
            int n_of_stu = liststudent.Count;
            //?????
            double gga = ga / n_of_stu;
            //????gga
            text_avg.Text = gga.ToString("0.00");


            /*max_value = arrscore.Max();
            max_idx = arrscore.ToList().IndexOf(max_value);
            
            student_max.Text = $"{arrid[max_idx]}";
            name_max.Text = $"{arrname[max_idx]}";
            socre_max.Text = $"{arrscore[max_idx]}";
           
            c_score = new int[arr_index];
            stop = arr_index;
            sub_arr_length = stop;
            Array.Copy(arrscore, start, c_score, 0, sub_arr_length);
            min_value = c_score.Min();
            
            min_idx = arrscore.ToList().IndexOf(min_value);
            
            student_min.Text = $"{arrid[min_idx]}";
            name_min.Text = $"{arrname[min_idx]}";
            socre_min.Text = $"{arrscore[min_idx]}";
            
            avg_point.Text = $"{(double)arrscore.Sum() / (double)arr_index:0.00}";*/

            /*            int point = arrscore[arr_index - 1];
                        if (point >= 80 && point <= 100)
                        {

                            n_grade[0] += 1;
                            textBox_A.Text = n_grade[0].ToString();
                            all_grade[0] = n_grade[0] * 4;

                        }
                        else if (point >= 75 && point <= 79)
                        {

                            n_grade[1] += 1;
                            textBox_B_pass.Text = n_grade[1].ToString();
                            all_grade[1] = n_grade[1] * 3.5f;
                        }
                        else if (point >= 70 && point <= 74)
                        {

                            n_grade[2] += 1;
                            textBox_B.Text = n_grade[2].ToString();
                            all_grade[2] = n_grade[2] * 3.0f;

                        }
                        else if (point >= 65 && point <= 69)
                        {

                            n_grade[3] += 1;
                            textBox_C_pass.Text = n_grade[3].ToString();
                            all_grade[3] = n_grade[3] * 2.5f;
                        }
                        else if (point >= 60 && point <= 64)
                        {

                            n_grade[4] += 1;
                            textBox_C.Text = n_grade[4].ToString();
                            all_grade[4] = n_grade[4] * 2.0f;
                        }
                        else if (point >= 55 && point <= 59)
                        {

                            n_grade[5] += 1;
                            textBox_D_pass.Text = n_grade[5].ToString();
                            all_grade[5] = n_grade[5] * 1.5f;
                        }
                        else if (point >= 50 && point <= 54)
                        {

                            n_grade[6] += 1;
                            textBox_D.Text = n_grade[6].ToString();
                            all_grade[6] = n_grade[6] * 1.0f;
                        }
                        else
                        {

                            n_grade[7] += 1;
                            textBox_F.Text = n_grade[7].ToString();
                        }

                        text_avg.Text = $"{(double)all_grade.Sum() / (double)arr_index:0.00}";*/



        }
    }
}
