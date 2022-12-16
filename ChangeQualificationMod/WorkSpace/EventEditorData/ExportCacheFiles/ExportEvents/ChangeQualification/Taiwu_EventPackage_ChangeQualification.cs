using System.Collections.Generic;
using Config.EventConfig;

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class Taiwu_EventPackage_ChangeQualification : EventPackage
	{
		public Taiwu_EventPackage_ChangeQualification()
		{
			NameSpace = "Taiwu";
			Author = "Modder_76561198296001474";
			Group = "ChangeQualification_2d9363e04918441281e84fd4ec7a0dac";
			EventList = new List<TaiwuEventItem>{
				new ChangeQualificationModEvent_b7eb79221e6b40af8640e12649a73e8a(),
				new ChangeQualificationModEvent_5d1130c5236f45daa69829962bb296a6(),
				new ChangeQualificationModEvent_5aab3fb9a681484691ad1924d024db1e(),
				new ChangeQualificationModEvent_f387e43facac4e88ae3292ccb64adfa7(),
				new ChangeQualificationModEvent_15221e83a2d3470cb3c7543678163dc6(),
				new ChangeQualificationModEvent_1dec845fa450401e99305d7d49252d01(),
				new ChangeQualificationModEvent_9d3a19f443554401a890b375843b5e67(),
				new ChangeQualificationModEvent_e2430dbcbe2b4e1f88e278e6b1e511c8(),
				new ChangeQualificationModEvent_8ed95c9f50f94de89c356cf6c5a185c7()
			};
		}
	}
}
