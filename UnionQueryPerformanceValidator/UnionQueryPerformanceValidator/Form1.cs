using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnionQueryPerformanceValidator
{
    public partial class Form1 : Form
    {
        private OracleDatabaseConnection m_dbcon;
        private StringQueryStore m_queryStore;
        private List<string> m_resultParallelQuery;
        private List<string> m_resultUnionQuery;
        public Form1()
        {
            InitializeComponent();
            m_dbcon = new OracleDatabaseConnection();
            m_queryStore = new StringQueryStore();
            m_resultParallelQuery = new List<string>();
            m_resultUnionQuery = new List<string>();
            m_dbcon.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        ~Form1()
        {
            m_dbcon.Close();
        }

        //Parallel Query Button
        private void button2_Click(object sender, EventArgs e)
        {
            /*m_resultParallelQuery.Clear();
            parallelQueryText.Text = "";

            var sw = Stopwatch.StartNew();
            Parallel.ForEach(m_queryStore.ReadQueriesFromStore(), query =>
            {
                m_dbcon.ExecuteQuery(query, m_resultParallelQuery);
            });
            var timeToExecute = sw.Elapsed.TotalSeconds;
            m_resultParallelQuery.OrderBy();
            sw.Stop();
            var totalexecutionTime = sw.Elapsed.TotalSeconds;
            TimeToExecute.Text = timeToExecute.ToString(CultureInfo.InvariantCulture);
            TimeToSort.Text = (totalexecutionTime - timeToExecute).ToString(CultureInfo.InvariantCulture);
            parallelQueryText.Text = totalexecutionTime.ToString(CultureInfo.InvariantCulture);*/

            var sw = Stopwatch.StartNew();
            m_resultParallelQuery = m_queryStore.ReadQueriesFromStore().AsParallel()
                .SelectMany(p => m_dbcon.ExecuteQuery(p)).OrderBy(o => o, StringComparer.Ordinal).ToList();
            sw.Stop();
            var totalexecutionTime = sw.Elapsed.TotalSeconds;
            parallelQueryText.Text = totalexecutionTime.ToString(CultureInfo.InvariantCulture);
        }

        //Union Query Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            unionQueryText.Text = "";
            var sw = Stopwatch.StartNew();
            m_resultUnionQuery = m_dbcon.ExecuteQuery(m_queryStore.ReadSingleUnionQuery());
            sw.Stop();
            var executionTime = sw.Elapsed.TotalSeconds;
            unionQueryText.Text = executionTime.ToString(CultureInfo.InvariantCulture);
        }

        private void ComapareButton_Click(object sender, EventArgs e)
        {
            var parallelQueryResultString = string.Join(",", m_resultParallelQuery.Select(o => o).ToArray());
            var unionQueryResultString = string.Join(",", m_resultUnionQuery.Select(o => o).ToArray());
            MessageBox.Show(parallelQueryResultString.Equals(unionQueryResultString).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
