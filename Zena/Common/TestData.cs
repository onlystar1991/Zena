using System.Collections.Generic;
using System.Linq;
using Zena.Models;

namespace Zena
{
	public class TestData
	{
		public static System.Collections.Generic.List<LearnContentArray> LearnContents = new System.Collections.Generic.List<LearnContentArray>
		{
			new LearnContentArray{
				id = 293,
				typeOfPost = 2,
				posterId = 2,
				postTime = "2016-06-26 10:30:20",
				lastEditTime = "2016-06-26 10:30:20",
				lastEditedBy = 8059,
				fairContent = true,
				published = true,
				anonymous = false,
				fileListId = 14113,
				postTitle = "Docscope Dental care",
				urlPart = "docscope-dental-care"
			},
			new LearnContentArray{
				id = 293,
				typeOfPost = 2,
				posterId = 2,
				postTime = "2016-06-26 10:30:20",
				lastEditTime = "2016-06-26 10:30:20",
				lastEditedBy = 8059,
				fairContent = true,
				published = true,
				anonymous = false,
				fileListId = 14113,
				postTitle = "Docscope Dental care",
				urlPart = "docscope-dental-care"
			},
			new LearnContentArray{
				id = 293,
				typeOfPost = 2,
				posterId = 2,
				postTime = "2016-06-26 10:30:20",
				lastEditTime = "2016-06-26 10:30:20",
				lastEditedBy = 8059,
				fairContent = true,
				published = true,
				anonymous = false,
				fileListId = 14113,
				postTitle = "Docscope Dental care",
				urlPart = "docscope-dental-care",
				postBody = new PostBody 
				{
					content = "Diabetes is a life style disease which " +
						"affects every organ of our body. This disease is related to malfunctioning" +
						" in carbohydrate, fat or protein metabolism. It affects teeth and bone alike. " +
						"Most common changes are bone loss which give riseto periodontal diseases " +
						"which affect attachment apparatus of tooth. High level of blood glucose affects " +
						"biotransformation of any drug in body and decrease the concentration of a " +
						"drug to reach target organ.\\n\\t\\tDental care related to " +
						"diabetes is good maintenance of good oral hygiene. " +
						"Maintenance of blood glucose is required in any dental treatment like " +
						"tooth extractions or minor surgical cases. " +
						"Uncontrolled diabetes is contraindication to many dental procedures. " +
						"Consultation with physician and endocrinologist is required for proper diet control and " +
						"administration of oral hypo glycemic drugs. " +
						"Utmost care should be taken during dental treatment for the prevention of diabetic " +
						"coma or insulin shock."
				}
			},
		};
	}
}

