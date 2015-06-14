using UnityEngine;
using System.Collections;

public struct Block{

protected enum Type { //тип блоков
		empty, //воздух. Изначально он везде
		floor, //Потолок и пол
		wall, //стена
		eventtrigger, /*блок похожий на воздух, но при определенных обстоятельствах становится заполненым геометрией
		Здесь нельзя спаунить монстра, кроме того, не все модели могут здесь появляться*/
		stairs
	}
private bool isGrouped; //Блок является основой чего-то?
}
