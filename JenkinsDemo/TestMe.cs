namespace JenkinsDemo
{
    public class TestMe
    {
        public string sayJenkins(int times)
        {
            string str = "";
            for (int i = 0; i < times; i++)
            {
                str += "Jenkins";
            }
            return str;
        }
    }
}
