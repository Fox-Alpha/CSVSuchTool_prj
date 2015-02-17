/*
 * Erstellt mit SharpDevelop.
 * Benutzer: buck
 * Datum: 12.12.2014
 * Zeit: 09:19
 * 
 */
using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
//using Ribbon = System.Windows.Controls.Ribbon;
using LumenWorks.Framework.IO.Csv;
using ExtendedForms;

namespace CSVSuchTool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		#region properties
		string _strFileName;
		
		public string strFileName {
			get { return _strFileName; }
			set { _strFileName = value; }
		}
		
		bool _bDoSearch;
		
		public bool bDoSearch {
			get { return _bDoSearch; }
			set { _bDoSearch = value; }
		}
		
	    // Determine whether Windows XP or a later
	    // operating system is present.
	    private bool isRunningXPOrLater = 
	        OSFeature.Feature.IsPresent(OSFeature.Themes);
	
	    // Declare a Hashtable array in which to store the groups.
	    private Hashtable[] groupTables;
	
	    // Declare a variable to store the current grouping column.
	    int groupColumn = 0;
	    
		#endregion
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//
			//	Quelldatei aus Settingsladen
			//
			strFileName = CSVSuchTool.Properties.Application.Default.sourceFile;
			//
			//	####
			//
			bDoSearch = false;
		}
		
		void MainForm_KeyUp(object sender, KeyEventArgs e)
		{
			
		}
		
		public void MainForm_SearchPhoneNo(string strPhoneNo)
		{
			this.Text = string.Format("Suche nach: {0}", strPhoneNo);
			tbSearch.Text = strPhoneNo;
			bDoSearch = true;
		}
		
		public void MainForm_LoadDataFromSourceFile()
		{
		}
		
		void tbSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				//TODO: Suche nache Eingabe in der Liste
				ReadCsv(true);
			}
		}
		void ButtSourceFileClick(object sender, System.EventArgs e)
		{
			string strTmp = "";
			extForms efSourceFile = new extForms(extForms.exFormOptions.None);
			efSourceFile.strTitel = "Datei für die Suche auswählen";
			efSourceFile.strFileFilter = "CSV Datei wählen (*.csv)|*.csv|Datei auswählen (*.xls)|*.xls|XML files (*.xml)|*.xml|Datei auswählen (*.*)|*.*";
			
			
			if (efSourceFile.ShowInputDialog(ref strTmp) == DialogResult.OK)
			{
				strFileName = strTmp;
				labSourceFile.Text = strFileName;
				Properties.Application.Default.sourceFile = strFileName;
				Properties.Application.Default.Save();
				
				ReadCsv();

//				if (isRunningXPOrLater)
//		        {
//		            // Create the groupsTable array and populate it with one 
//		            // hash table for each column.
//		            groupTables = new Hashtable[listView1.Columns.Count];
//		            for (int column = 0; column < listView1.Columns.Count; column++)
//		            {
//		                // Create a hash table containing all the groups 
//		                // needed for a single column.
//		                groupTables[column] = CreateGroupsTable(column);
//		            }
//		
//		            // Start with the groups created for the Title column.
//		            SetGroups(0);
//		        }
			}
		}
		void ReadCsv(bool search = false)
		{
		    using (CsvReader csv =
		           new CsvReader(new StreamReader(strFileName), true, ';', '\"', '\"', '#', ValueTrimmingOptions.All, 4096))
		    {
		        int fieldCount = csv.FieldCount;
		
		        string[] headers = csv.GetFieldHeaders();
		        
			    string strSearchTerm = "";
			    int iSearchInColumn = 0;
			    if (search) 
			    {
			    	if((comboBox1.SelectedIndex = comboBox1.Items.IndexOf(comboBox1.Text)) >= 0)
			    	{
			    	}
			    	else if(comboBox1.Items.Count > 0 || comboBox1.SelectedIndex > headers.Length)
			    	{
			    		comboBox1.SelectedIndex = 0;
			    	}
			    	else
			    	{
			    		iSearchInColumn = groupColumn < 0 ? groupColumn : 0;
			    	}
			    	strSearchTerm = tbSearch.Text;
			    	
			    }

		        listView1.Columns.Clear();
		        comboBox1.Items.Clear();
				ColumnHeader[] clHeaderArray = new ColumnHeader[fieldCount];

				for (int i = 0; i < fieldCount; i++)
	            {
	            	clHeaderArray[i] = new ColumnHeader();
	            	clHeaderArray[i].Text = headers[i];
	            }
				listView1.Columns.AddRange(clHeaderArray);
				
				comboBox1.Items.AddRange(headers);
						        
				listView1.Items.Clear();
				
		        while (csv.ReadNextRecord())
		        {
					ListViewItem lvi = null;
					List<string> strLine = new List<string>();
					
   		            for (int i = 0; i < fieldCount; i++)
		            {
   		            	strLine.Add(csv[i]);
		            }

   		            if (search && !string.IsNullOrWhiteSpace(strSearchTerm)) {
   		            	if (Regex.IsMatch(csv[iSearchInColumn], strSearchTerm, RegexOptions.IgnoreCase))
						{
		   		            lvi = new ListViewItem(strLine.ToArray());
		   		            listView1.Items.Add(lvi);
						}
					}
   		            else
					{
	   		            lvi = new ListViewItem(strLine.ToArray());
	   		            listView1.Items.Add(lvi);
					}
			            
   		            strLine.Clear();
		        }		        
		        
		        foreach (ColumnHeader clHeader in listView1.Columns) {
		        	clHeader.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		        }
		    }

		    if (isRunningXPOrLater)
	        {
	            // Create the groupsTable array and populate it with one 
	            // hash table for each column.
	            groupTables = new Hashtable[listView1.Columns.Count];
	            for (int column = 0; column < listView1.Columns.Count; column++)
	            {
	                // Create a hash table containing all the groups 
	                // needed for a single column.
	                groupTables[column] = CreateGroupsTable(column);
	            }
	
	            // Start with the groups created for the Title column.
	            SetGroups(0);
	        }
		}
		void ListView1ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
	        // Set the sort order to ascending when changing
	        // column groups; otherwise, reverse the sort order.
	        if ( listView1.Sorting == SortOrder.Descending || 
	            ( isRunningXPOrLater && (e.Column != groupColumn) ) )
	        {
	            listView1.Sorting = SortOrder.Ascending;
	        }
	        else 
	        {
	            listView1.Sorting = SortOrder.Descending;
	        }
	        groupColumn = e.Column;
	
	        // Set the groups to those created for the clicked column.
	        if (isRunningXPOrLater)
	        {
	            SetGroups(e.Column);
	        }
		}
		
	    // Sets myListView to the groups created for the specified column.
	    private void SetGroups(int column)
	    {
	        // Remove the current groups.
	        listView1.Groups.Clear();
	
	        // Retrieve the hash table corresponding to the column.
	        Hashtable groups = (Hashtable)groupTables[column];
	
	        // Copy the groups for the column to an array.
	        ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
	        groups.Values.CopyTo(groupsArray, 0);
	
	        // Sort the groups and add them to myListView.
	        Array.Sort(groupsArray, new ListViewGroupSorter(listView1.Sorting));
	        listView1.Groups.AddRange(groupsArray);
	
	        // Iterate through the items in myListView, assigning each 
	        // one to the appropriate group.
	        foreach (ListViewItem item in listView1.Items)
	        {
	            // Retrieve the subitem text corresponding to the column.
	            string subItemText = item.SubItems[column].Text;
	
	            if (!string.IsNullOrWhiteSpace(subItemText))
	            {
		            // For the Title column, use only the first letter.
		            if (column == 0) 
		            {
		                subItemText = subItemText.Substring(0, 1);
		            }
		
		            // Assign the item to the matching group.
		            item.Group = (ListViewGroup)groups[subItemText];
	            }
	        }
	    }
	
	    // Creates a Hashtable object with one entry for each unique
	    // subitem value (or initial letter for the parent item)
	    // in the specified column.
	    private Hashtable CreateGroupsTable(int column)
	    {
	        // Create a Hashtable object.
	        Hashtable groups = new Hashtable();
	
	        // Iterate through the items in myListView.
	        foreach (ListViewItem item in listView1.Items)
	        {
	            // Retrieve the text value for the column.
	            string subItemText = item.SubItems[column].Text;
	
	            if (!string.IsNullOrWhiteSpace(subItemText))
	            {
		            // Use the initial letter instead if it is the first column.
		            if (column == 0) 
		            {
		                subItemText = subItemText.Substring(0, 1);
		            }
		
		            // If the groups table does not already contain a group
		            // for the subItemText value, add a new group using the 
		            // subItemText value for the group header and Hashtable key.
		            if (!groups.Contains(subItemText))
		            {
		                groups.Add( subItemText, new ListViewGroup(subItemText, 
		                    HorizontalAlignment.Left) );
		            }
	            }
	        }
	
	        // Return the Hashtable object.
	        return groups;
	    }
		void tbSearch_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox) {
				((TextBox)sender).SelectionStart = 1;
				((TextBox)sender).SelectAll();
			}
		}
		void MainForm_Shown(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(strFileName)) {
				labSourceFile.Text = strFileName;
				ReadCsv(bDoSearch);
				//this.AutoSize = true;
				
				if(bDoSearch)
				{
					
				}
				
				if (comboBox1.Items.Count > 0) {
					comboBox1.SelectedIndex = 0;
				}
			}
			strFileName = CSVSuchTool.Properties.Application.Default.sourceFile;
			Location = CSVSuchTool.Properties.Application.Default.SearchFormPosition;
			Size = CSVSuchTool.Properties.Application.Default.SearchFormSize;
		}
		void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CSVSuchTool.Properties.Application.Default.SearchFormPosition = Location;
			CSVSuchTool.Properties.Application.Default.SearchFormSize = Size;
			CSVSuchTool.Properties.Application.Default.Save();
		}
		void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
/*
 * 			//Debug.WriteLine(sender.GetType().ToString(), "contextMenuStrip1_Opening()");
			ContextMenuStrip cms = null;
			ListView.ColumnHeaderCollection chc = null;
			ToolStripMenuItem tsmi = null;
			ToolStripItem[] tsi = null;
			
			if((cms = sender as ContextMenuStrip) != null)
			{
				//cms.Items.Clear();
				chc = listView1.Columns;
				int i = 0;
				foreach (ColumnHeader ch in chc) { 
					if ((tsi = cms.Items.Find("popupMenu_" + ch.Index.ToString(), true)).Length == 0) {
						tsmi = new ToolStripMenuItem(ch.Text, null, testToolStripMenuItem_Click);
						tsmi.Checked = true;
						tsmi.Name = "popupMenu_" + ch.Index.ToString();;
						cms.Items.Add(tsmi);
					}
				}				
			}
*/
		}
		
		void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem tsmi = null;
			
			if((tsmi = sender as ToolStripMenuItem) != null)
			{
				tsmi.Checked = !tsmi.Checked;
			}
		}
	}
	
    // Sorts ListViewGroup objects by header value.
    class ListViewGroupSorter : IComparer
    {
        private SortOrder order;

        // Stores the sort order.
        public ListViewGroupSorter(SortOrder theOrder) 
        { 
            order = theOrder;
        }

        // Compares the groups by header value, using the saved sort
        // order to return the correct value.
        public int Compare(object x, object y)
        {
            int result = String.Compare(
                ((ListViewGroup)x).Header,
                ((ListViewGroup)y).Header, StringComparison.CurrentCultureIgnoreCase
            );
            if (order == SortOrder.Ascending)
            {
                return result;
            }
            else 
            {
                return -result;
            }
        }
    }
}
