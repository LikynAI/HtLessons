using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeruNeVeru2
{
	public class Question
	{
		public string text;   
		public bool trueFalse;
							  			  
		public Question(){		}

		public Question(string text, bool trueFalse)
		{
			this.text = text;
			this.trueFalse = trueFalse;
		}

		
	}

}
