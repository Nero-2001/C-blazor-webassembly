using BlazorGantt;
using System.Collections.Generic;

namespace CCTruckQ
{
	public class GanttDto
	{
		public List<Task_Data> datas { get; set; }=new List<Task_Data>();
		public List<Task_Link> links { get; set; }= new List<Task_Link>();
	}
}
