using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.StreamingService
{
	class ConferenceRecordFile: EntityBase
	{
		public IUser Owner { get; set; }
		public string FileName { get; set; }
		public string Path { get; set; }
	}
}
