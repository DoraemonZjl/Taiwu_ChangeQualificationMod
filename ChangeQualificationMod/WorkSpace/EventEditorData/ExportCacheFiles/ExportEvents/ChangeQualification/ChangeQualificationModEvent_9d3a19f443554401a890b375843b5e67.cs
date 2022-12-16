using System;
using System.Linq;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;
using GameData.Domains.TaiwuEvent.DisplayEvent;
using GameData.Domains.TaiwuEvent.EventOption;
using GameData.Domains.Character;
using GameData.Domains.Character.AvatarSystem;
using GameData.Domains.Combat;
using GameData.Domains.CombatSkill;
using GameData.Domains.Character.Relation;
using GameData.Domains.Adventure;
using GameData.Domains.Item;
using GameData.Domains.Item.Display;
using GameData.Domains.World;
using GameData.Domains.Information;
using GameData.Domains.Map;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent.EventHelper;


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_9d3a19f443554401a890b375843b5e67 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_9d3a19f443554401a890b375843b5e67()
		{
			//事件GUID
			Guid = Guid.Parse("9d3a19f4-4355-4401-a890-b375843b5e67");
			//该事件是否是头部事件
			IsHeadEvent = true;
			//事件分组
			EventGroup = "ChangeQualification";
			//同一时间是否强制只允许触发一个同组事件
			ForceSingle = false;
			//事件类型
			EventType = EEventType.ModEvent;
			//事件触发点类型
			TriggerType = EventTrigger.NewGameMonth;
			//事件排序执行的优先级
			EventSortingOrder = 999;
			//事件内容
			//EventContent = "";
			//进行决策的角色的Key，为空时将不显示选项上的角色头像
			MainRoleKey = "";
			//进行交互的角色的Key，为空时将不显示背景图上的角色头像
			TargetRoleKey = "";
			//事件背景图，为空表示该事件使用地块适应的背景图
			EventBackground = "";
			//事件对遮罩的控制
			MaskControl = EventMaskControl.NoChange;
			//遮罩渐变的时间
			MaskTweenTime = 0f;
			//绑定在Esc按键处理的选项Key
			EscOptionKey = "";
			//选项列表
			EventOptions = new TaiwuEventOption[]		        
			{
				
			};
			InitOptions();		
		}


		#region EventAPI
		private void InitOptions()
		{
		}

		    public override bool OnCheckEventCondition()
		    {
		        int modCharacterId = -1;
		        bool flag = TaiwuEvent.GetModData("ModCharacterId",true,ref modCharacterId);
		        if(flag==false)
		        {
		            EventHelper.Log("8-判断mod人物是否死亡：未拿到mod人物id。");
		            return false;
		        }
		        else
		        {
		            GameData.Domains.Character.Character modCharacter = EventHelper.GetCharacterById(modCharacterId);
		            bool checkModCharacterIsDied = EventHelper.CheckRoleDied(modCharacter);
		            if(checkModCharacterIsDied)
		            {
		                EventHelper.Log("8-判断mod人物是否死亡：mod人物已死亡，跳转0-添加MOD对话人物事件。");
		                return true;
		            }
		            else
		            {
		                EventHelper.Log("8-判断mod人物是否死亡：mod人物未死亡，不做处理。");
		                return false;
		            }
		        }
		    }

		    public override void OnEventEnter()
		    {
		        TaiwuEvent.RemoveModBool("ChangeQualificationMod", true);
		        EventHelper.ToEvent("15221e83-a2d3-470c-b3c7-543678163dc6");
		        return;
		    }

		    public override void OnEventExit()
		    {
		    }

		    public override string GetReplacedContentString()
		    {
		        return string.Empty;
		    }

		    public override List<string> GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion

		#region Options

		#endregion
	}
}