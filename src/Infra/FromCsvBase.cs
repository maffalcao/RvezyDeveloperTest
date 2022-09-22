namespace Infra
{
    public abstract class FromCsvBase
    {
        protected string FILE_PATH { get; set; }

        public FromCsvBase()
        {
            FILE_PATH = "";
        }

        public void GetFileData()
        {
            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                string currentLine;

                while ((currentLine = sr.ReadLine()) != null)
                {
                    ProccessLineContent(currentLine);
                }
            }
        }

        protected abstract void ProccessLineContent(string lineContent);
    }
}