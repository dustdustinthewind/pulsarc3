// MapData
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class MapData
{
	public class EData
	{
		public int version = 1;

		public List<MapEvent> events = new List<MapEvent>();
	}

	public int configVersion = 1;

	public string name = "No Name";

	public string info = "No info";

	public List<MapResource> levelResources = new List<MapResource>();

	public List<string> tags = new List<string>();

	public int handCount = 1;

	public string moreInfoURL = string.Empty;

	public float speed = 15f;

	public int lives = 5;

	public int maxLives = 6;

	public string musicFile = "music.ogg";

	public float musicTime;

	public string iconFile = "icon.png";

	public int environmentType;

	public List<string> unlockConditions = new List<string>();

	public bool hidden;

	public List<float> checkpoints = new List<float>();

	public List<MapEvent> events = new List<MapEvent>();

	public string e = string.Empty;

	private void JDOHGHPOMNB(float DBIMJHMKHNK)
	{
		checkpoints.Add(DBIMJHMKHNK);
	}

	public static int GetLastConfigVersion()
	{
		return 3;
	}

	private void ONBJIBMMIBJ(MapEvent DBIMJHMKHNK)
	{
		events.Add(new MapEvent(DBIMJHMKHNK));
	}

	public static int LADNNJPOJFG()
	{
		return 5;
	}

	public MapData(MapData CLCBMMEKBBC)
	{
		configVersion = CLCBMMEKBBC.configVersion;
		name = CLCBMMEKBBC.name;
		info = CLCBMMEKBBC.info;
		levelResources = CLCBMMEKBBC.levelResources;
		moreInfoURL = CLCBMMEKBBC.moreInfoURL;
		speed = CLCBMMEKBBC.speed;
		lives = CLCBMMEKBBC.lives;
		maxLives = CLCBMMEKBBC.maxLives;
		handCount = CLCBMMEKBBC.handCount;
		musicFile = CLCBMMEKBBC.musicFile;
		musicTime = CLCBMMEKBBC.musicTime;
		iconFile = CLCBMMEKBBC.iconFile;
		environmentType = CLCBMMEKBBC.environmentType;
		e = CLCBMMEKBBC.e;
		unlockConditions = new List<string>(CLCBMMEKBBC.unlockConditions.Count);
		CLCBMMEKBBC.unlockConditions.ForEach(delegate(string DBIMJHMKHNK)
		{
			if (!string.IsNullOrEmpty(DBIMJHMKHNK))
			{
				unlockConditions.Add(DBIMJHMKHNK);
			}
		});
		tags = new List<string>(CLCBMMEKBBC.tags.Count);
		CLCBMMEKBBC.tags.ForEach(delegate(string DBIMJHMKHNK)
		{
			if (!string.IsNullOrEmpty(DBIMJHMKHNK))
			{
				tags.Add(DBIMJHMKHNK);
			}
		});
		hidden = CLCBMMEKBBC.hidden;
		checkpoints = new List<float>(CLCBMMEKBBC.checkpoints.Count);
		CLCBMMEKBBC.checkpoints.ForEach(delegate(float DBIMJHMKHNK)
		{
			checkpoints.Add(DBIMJHMKHNK);
		});
		events = new List<MapEvent>(CLCBMMEKBBC.events.Count);
		CLCBMMEKBBC.events.ForEach(delegate(MapEvent DBIMJHMKHNK)
		{
			events.Add(new MapEvent(DBIMJHMKHNK));
		});
	}

	public static int GAEEAAPAIAI()
	{
		return 1;
	}

	private void LEGENHENDCN(float DBIMJHMKHNK)
	{
		checkpoints.Add(DBIMJHMKHNK);
	}

	[CompilerGenerated]
	private void OPBCIJIADAH(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			tags.Add(DBIMJHMKHNK);
		}
	}

	private void AIJKGBMMPHK(float DBIMJHMKHNK)
	{
		checkpoints.Add(DBIMJHMKHNK);
	}

	private void PNGPIMCLCLF(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			tags.Add(DBIMJHMKHNK);
		}
	}

	private void PMCBNJJNCFM(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			tags.Add(DBIMJHMKHNK);
		}
	}

	private void AFGCPMFKJHO(MapEvent DBIMJHMKHNK)
	{
		events.Add(new MapEvent(DBIMJHMKHNK));
	}

	[CompilerGenerated]
	private void EHJOEOCEKOA(float DBIMJHMKHNK)
	{
		checkpoints.Add(DBIMJHMKHNK);
	}

	public static int JDMEGDFFPFG()
	{
		return 2;
	}

	public MapData()
	{
	}

	public static int GODJBCPCIME()
	{
		return 3;
	}

	[CompilerGenerated]
	private void DHNKCBGELNF(MapEvent DBIMJHMKHNK)
	{
		events.Add(new MapEvent(DBIMJHMKHNK));
	}

	private void OJDPPFLMKKN(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			unlockConditions.Add(DBIMJHMKHNK);
		}
	}

	[CompilerGenerated]
	private void BOJHOBEALCC(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			unlockConditions.Add(DBIMJHMKHNK);
		}
	}

	private void FPCLPFKFLJJ(string DBIMJHMKHNK)
	{
		if (!string.IsNullOrEmpty(DBIMJHMKHNK))
		{
			tags.Add(DBIMJHMKHNK);
		}
	}
}
