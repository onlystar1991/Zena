using System;
using System.Collections.Generic;
using System.Linq;

namespace Zena.Models
{
	public class Status
	{
		public string result { get; set; }
		public string action { get; set; }
	}

	public class PostBody
	{
		public string content { get; set; }
	}

	public class LearnContentArray
	{
		public int id { get; set; }
		public int typeOfPost { get; set; }
		public int posterId { get; set; }
		public string postTime { get; set; }
		public string lastEditTime { get; set; }
		public int lastEditedBy { get; set; }
		public bool fairContent { get; set; }
		public bool published { get; set; }
		public bool anonymous { get; set; }
		public int fileListId { get; set; }
		public string postTitle { get; set; }
		public string urlPart { get; set; }
		public PostBody postBody { get; set; }
		public string likeData { get; set; }
		public string meta { get; set; }
		public object openingPicId { get; set; }
		public string posterName { get; set; }
		public string openingPicUrl { get; set; }
	}

	public class List
	{
		public int count { get; set; }
		public List<LearnContentArray> learnContentArray { get; set; }
	}

	public class Data
	{
		public List list { get; set; }
	}

	public class LearnContentModel
	{
		public Status status { get; set; }
		public Data data { get; set; }
	}
}