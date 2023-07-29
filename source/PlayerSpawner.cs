// PlayerSpawner
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
	public List<GameObject> spawnPoints;

	public List<GameObject> segments;

	public PlayerBase pbase;

	public GameObject IKHKPEGCGDH(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
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
			gameObject.GetComponent<SegmentHandler>().ALKBNPMCEOM(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EJLKPLOEEEP();
		}
		return gameObject;
	}

	public void IJABOLGOAJJ(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 8;
		}
		GameObject gameObject = KEDHNCEBKLE(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1583f;
	}

	public void AHGKNDNNELO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = FGDMJCCNMMO(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().HPAnimationTime);
	}

	public GameObject BMBEHOMJAJB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().CAJFKNFJEKC(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EJLKPLOEEEP();
		}
		return gameObject;
	}

	public GameObject JBGFPBGCNLO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().EOPEMLDJAAO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().FIMJABKECNG();
		}
		return gameObject;
	}

	public GameObject DAJAIPNDNJO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().KJBJBNGJDAD(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LCKKDMKJJEF();
		}
		return gameObject;
	}

	public void ELJCIMPOEPL(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = DGDDKLNFJDI(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1521f;
	}

	public GameObject PGKPDOKAKPB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
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
			gameObject.GetComponent<SegmentHandler>().PAFMNAIDAFH(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().Init();
		}
		return gameObject;
	}

	public void LEPDOCHGDLE(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = AJNCBGCPIIF(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 591f;
	}

	public GameObject AJNCBGCPIIF(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
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
			gameObject.GetComponent<SegmentHandler>().CFKJHLOEDFO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EMOCEKPLGBK();
		}
		return gameObject;
	}

	public void GCNKIJDNPMD()
	{
	}

	public void DKEIFPBDDEG(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = AJNCBGCPIIF(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 684f;
	}

	public GameObject DGDDKLNFJDI(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
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
			gameObject.GetComponent<SegmentHandler>().PFMJPIJONIP(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().PIEPPKMBJHI();
		}
		return gameObject;
	}

	public void MNDBJHPIOCH(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = MECJANHJKJN(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().PJHGHEKLOCH());
	}

	public void OIICDOCKJLJ(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = BMBEHOMJAJB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().EIFMOHOFICD());
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

	public GameObject BMNLJGKJCMK(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().LLAHPNGMEOO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LLAHPNGMEOO();
		}
		return gameObject;
	}

	public GameObject KEDHNCEBKLE(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
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
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if ((bool)gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().LBICLFNOLAK(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().HBKEHHCMMBN();
		}
		return gameObject;
	}

	public void APOAKNCELIN(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = DAJAIPNDNJO(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.DCLNDDJJJMA().PJHGHEKLOCH());
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

	public void FECMEIJGLJI()
	{
	}

	public void ALKBNPMCEOM()
	{
	}

	public void LLAHPNGMEOO()
	{
	}

	public GameObject DCANBOAFPMB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().CPFOEFKOJGA(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().PIEPPKMBJHI();
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

	public void Init()
	{
	}

	public void LJGONBGGNHI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = BMNLJGKJCMK(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().LEFLMCJDFJP());
	}

	public GameObject FGDMJCCNMMO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().Init(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LCGMHCBNCDM();
		}
		return gameObject;
	}

	public void OICMMIDHIDB(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 7)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = FGDMJCCNMMO(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1986f;
	}

	public GameObject GGFNGECNAML(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().GAJEPOEIOPP(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().CAJFKNFJEKC();
		}
		return gameObject;
	}

	public void AKBOBNPBAAO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = DCANBOAFPMB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().PJHGHEKLOCH());
	}

	public void MFILHAGLPOI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 4;
		}
		GameObject gameObject = KEDHNCEBKLE(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().HPAnimationTime);
	}

	public void GOFFBMGGEJI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = MECJANHJKJN(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().EIFMOHOFICD());
	}

	public void FKAFFNFNCLD(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = PGKPDOKAKPB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.GetGameScene().LEFLMCJDFJP());
	}

	public GameObject MECJANHJKJN(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
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
			gameObject.GetComponent<SegmentHandler>().FFBDGOBNNCO(pbase);
		}
		if ((bool)gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EKOAKKNGGGI();
		}
		return gameObject;
	}

	public void LJLKDFCEIOO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = DGDDKLNFJDI(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1102f;
	}

	public void NANCLEIDNPM(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = MECJANHJKJN(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 319f;
	}

	public void HLFODJHLNID(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = SpawnAndReturn(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1700f;
	}

	public void KHPNFJFIEKF(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 8;
		}
		GameObject gameObject = PGKPDOKAKPB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.DCLNDDJJJMA().HPAnimationTime);
	}

	public void HBKEHHCMMBN()
	{
	}

	public void NBIEIGBAKND()
	{
	}

	public void POGJLIDHDIH()
	{
	}

	public void KELAPPFFMFM(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 4;
		}
		GameObject gameObject = DGDDKLNFJDI(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1054f;
	}

	public void ECKJCPIFAHD(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = PGKPDOKAKPB(FKCMGBMNNKA, spawnPoints[KEMDFEFBIOC].transform.position, spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - (float)pbase.DCLNDDJJJMA().DADGJKNFIIK());
	}
}
