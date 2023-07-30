// PlayerSpawner
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
	public List<GameObject> spawnPoints;

	public List<GameObject> segments;

	public PlayerBase pbase;

	public GameObject BHLCAGGJPJL(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.FIEBPKBBNEG(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().LBICLFNOLAK(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EEMIHIFBFFJ();
		}
		return gameObject;
	}

	public GameObject DGDDKLNFJDI(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BHJJDDDEJDO(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().FFBDGOBNNCO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().OMBOBKJBLKC();
		}
		return gameObject;
	}

	public GameObject BMBEHOMJAJB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BHJJDDDEJDO(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().Init(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().DDKHMCOOCPA();
		}
		return gameObject;
	}

	public void HLFODJHLNID(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = DGDDKLNFJDI(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 679f;
	}

	public GameObject MECJANHJKJN(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.LDJBCIEGNJD(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().HBKEHHCMMBN(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().PMAGMPCMGPB();
		}
		return gameObject;
	}

	public GameObject PGKPDOKAKPB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.LDJBCIEGNJD(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().HBKEHHCMMBN(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().FNEKLACBDFL();
		}
		return gameObject;
	}

	public void EGFGOELGNDF(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 7)
		{
			KEMDFEFBIOC = 3;
		}
		GameObject gameObject = BMNLJGKJCMK(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().JFBBJAAHPAH());
	}

	public void Init()
	{
	}

	public void GBAIAFJNNGP(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 3)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = EDBMHDDDFFJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().LEFLMCJDFJP());
	}

	public void KODHADKPAOO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = DGPBFODIDDD(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1592f;
	}

	public void SpawnWithCureentSpeed(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = SpawnAndReturn(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + -1.5f;
	}

	public void KHPNFJFIEKF(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = PGKPDOKAKPB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().OBANGBMECKE());
	}

	public void LLAHPNGMEOO()
	{
	}

	public void DHDBEJGHHOH(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = MKHKBIDPEKJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().OBANGBMECKE());
	}

	public void IFGOHEOEGKH()
	{
	}

	public void DMNMMBPCBPF(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 7)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = HDPOAHKCEFJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1680f;
	}

	public void OICMMIDHIDB(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = DGPBFODIDDD(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 2f;
	}

	public void EOPEMLDJAAO()
	{
	}

	public void NLPGOKCHGLC(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = BHLCAGGJPJL(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().DKDDGCBMDCM());
	}

	public void GNHMPPIDOJI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = MKHKBIDPEKJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 480f;
	}

	public void IGLHMLLCGGN(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 3;
		}
		GameObject gameObject = MECJANHJKJN(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().HPAnimationTime);
	}

	public void NBIEIGBAKND()
	{
	}

	public void ONBFCIDBCLA(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = MECJANHJKJN(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().JFBBJAAHPAH());
	}

	public void Spawn(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = SpawnAndReturn(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().HPAnimationTime);
	}

	public GameObject PJAKDPNAAFO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BHJJDDDEJDO(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().HBKEHHCMMBN(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().NOBNCNJKOLA();
		}
		return gameObject;
	}

	public void FEJAAGGMBOE()
	{
	}

	public void GNHJPECPFGG(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = BHLCAGGJPJL(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1149f;
	}

	public GameObject HDPOAHKCEFJ(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().IFGOHEOEGKH(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EIPPDLDJJGO();
		}
		return gameObject;
	}

	public void KOPNFEOKHFD(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 3;
		}
		GameObject gameObject = EDBMHDDDFFJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().LHBKKELHJKJ());
	}

	public GameObject DGPBFODIDDD(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.FIEBPKBBNEG(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().LBICLFNOLAK(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().CANIHLHGGOF();
		}
		return gameObject;
	}

	public void BDOOKMJBBEL(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = SpawnAndReturn(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().DKDDGCBMDCM());
	}

	public void JDPGBFAJPKJ(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 6;
		}
		GameObject gameObject = HDPOAHKCEFJ(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1972f;
	}

	public void DHBCMLPCMIK(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 6;
		}
		GameObject gameObject = DGDDKLNFJDI(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 201f;
	}

	public GameObject MKHKBIDPEKJ(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.LDJBCIEGNJD(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().Init(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().OMBOBKJBLKC();
		}
		return gameObject;
	}

	public GameObject SpawnAndReturn(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().Init(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().Init();
		}
		return gameObject;
	}

	public GameObject EDBMHDDDFFJ(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.FIEBPKBBNEG(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().HBKEHHCMMBN(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().CFKJHLOEDFO();
		}
		return gameObject;
	}

	public void JFIBHNBMCGA(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = DGPBFODIDDD(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 305f;
	}

	public GameObject BMNLJGKJCMK(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BHJJDDDEJDO(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().FFBDGOBNNCO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().MIAIEKCLEAO();
		}
		return gameObject;
	}

	public void MFILHAGLPOI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 7)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = BHLCAGGJPJL(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().HKEENHMCALF());
	}

	public GameObject FNAEKCMFNKL(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(pbase.playerController.objects[KEMDFEFBIOC].transform);
		if ((bool)gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().IFGOHEOEGKH(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().OMBOBKJBLKC();
		}
		return gameObject;
	}

	public void EKOAKKNGGGI()
	{
	}

	public void FECMEIJGLJI()
	{
	}
}
