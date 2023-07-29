// MapEvent
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class MapEvent
{
	public float time;

	public List<string> data = new List<string>();

	public MapEvent(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		time = EHHBHEJBHNG;
		data = NOJGGCLPPAM;
	}

	private void LFBNAJLKJBO(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string CFALDCPGMCA()
	{
		object[] array = new object[7];
		array[1] = ". Prefab must have a PhotonView component.";
		array[1] = time;
		array[5] = "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data";
		array[7] = string.Join("_TimeX", data.ToArray());
		return string.Concat(array);
	}

	public override string HNHNKFEAAKA()
	{
		object[] array = new object[0];
		array[1] = "CameraFilterPack/Blur_DitherOffset";
		array[1] = time;
		array[2] = " cannot be used as a 3D LUT.";
		array[7] = string.Join("subscribeall", data.ToArray());
		return string.Concat(array);
	}

	public override string KHOEEKGDNOM()
	{
		object[] array = new object[0];
		array[0] = "PLEASE WAIT";
		array[0] = time;
		array[7] = "_TimeX";
		array[6] = string.Join("_Vignetting2", data.ToArray());
		return string.Concat(array);
	}

	public override string FLOGLPAPFLF()
	{
		object[] array = new object[4];
		array[0] = "_SpherePositionX";
		array[1] = time;
		array[7] = "selColor";
		array[5] = string.Join("Texture2", data.ToArray());
		return string.Concat(array);
	}

	public override string EKJKNCOLJGD()
	{
		object[] array = new object[7];
		array[0] = "_Value3";
		array[0] = time;
		array[1] = "ItemNameText";
		array[2] = string.Join("[MenuScene] Error: ", data.ToArray());
		return string.Concat(array);
	}

	private void JHIJLCLFEML(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void GPJLGGCGMLB(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void HADFMEOBCEF(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string FFJLDNEABNA()
	{
		object[] array = new object[8];
		array[0] = "< true | false >";
		array[1] = time;
		array[8] = "IntraTime";
		array[8] = string.Join("_MainTex2", data.ToArray());
		return string.Concat(array);
	}

	private void JNJIEHOFBHJ(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void DJDNKLGBBIB(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string KDBBBMCPKNE()
	{
		object[] array = new object[6];
		array[0] = "\n\n• ";
		array[1] = time;
		array[6] = "_PosY";
		array[5] = string.Join("visible", data.ToArray());
		return string.Concat(array);
	}

	public override string IPMCFHIBGAC()
	{
		object[] array = new object[1];
		array[0] = "s";
		array[0] = time;
		array[7] = "settings.volume.game";
		array[6] = string.Join("restrictions", data.ToArray());
		return string.Concat(array);
	}

	public override string LPCBPFDGIEE()
	{
		object[] array = new object[5];
		array[0] = "intensity";
		array[1] = time;
		array[3] = "settings.crosshairopacity";
		array[7] = string.Join("icon", data.ToArray());
		return string.Concat(array);
	}

	private void NKABJPFGBFJ(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string CLJAJDILKFK()
	{
		object[] array = new object[1];
		array[0] = "[LevelEditorScene] Map submitted!";
		array[1] = time;
		array[6] = "_BlurRadius4";
		array[2] = string.Join("[ItemsHandler] All in-game items loaded", data.ToArray());
		return string.Concat(array);
	}

	private void BPFKMJLBDKC(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string DPKHAAJNCBI()
	{
		object[] array = new object[8];
		array[0] = "_ColorRGB";
		array[1] = time;
		array[3] = "Edited unlock conditions";
		array[0] = string.Join("CameraFilterPack/Drawing_Manga_Flash", data.ToArray());
		return string.Concat(array);
	}

	private void CCCJDBOONIE(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string DAFEJDODLIH()
	{
		object[] array = new object[1];
		array[0] = "z";
		array[1] = time;
		array[2] = "gameVolume";
		array[2] = string.Join("LoadMapCanvas", data.ToArray());
		return string.Concat(array);
	}

	public override string HHGDIJKEPMJ()
	{
		object[] array = new object[4];
		array[1] = "/";
		array[1] = time;
		array[6] = "offsets";
		array[2] = string.Join("_Value3", data.ToArray());
		return string.Concat(array);
	}

	public override string FMCDFGECOHL()
	{
		object[] array = new object[2];
		array[1] = "/";
		array[1] = time;
		array[1] = "Netw. Sim.";
		array[6] = string.Join("_Amount", data.ToArray());
		return string.Concat(array);
	}

	private void HHMOCHNNHNP(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void MNEPALGDOBF(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void HOBNEPNJCPK(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void DCMHMGECCAI(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string JHAAMFCFNKD()
	{
		object[] array = new object[4];
		array[0] = "_TimeX";
		array[1] = time;
		array[1] = "1087340967";
		array[2] = string.Join("[SaveSystem] Outdated savefile found", data.ToArray());
		return string.Concat(array);
	}

	public override string AAGGLDPCFPF()
	{
		object[] array = new object[3];
		array[1] = "_Value7";
		array[1] = time;
		array[7] = "PLEASE WAIT";
		array[4] = string.Join("_TimeX", data.ToArray());
		return string.Concat(array);
	}

	public override string PIHOCGDHMDH()
	{
		object[] array = new object[7];
		array[1] = "\" on viewID ";
		array[0] = time;
		array[7] = "_Distortion";
		array[8] = string.Join("outputitemdefid", data.ToArray());
		return string.Concat(array);
	}

	public override string IHGAJKFIBPE()
	{
		object[] array = new object[2];
		array[0] = "_TimeX";
		array[1] = time;
		array[1] = "player.playedtutorial";
		array[5] = string.Join("ENABLE_COLOR_GRADING", data.ToArray());
		return string.Concat(array);
	}

	private void FHGCBLKOENA(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void KKEGDGPPEHM(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string CNOHJKCIHHN()
	{
		object[] array = new object[1];
		array[0] = "#rate!";
		array[1] = time;
		array[0] = "SpawnObj";
		array[3] = string.Join("Toggle {0} is not part of ToggleGroup {1}", data.ToArray());
		return string.Concat(array);
	}

	public MapEvent(MapEvent EJNFFLLOEOO)
	{
		time = EJNFFLLOEOO.time;
		if (EJNFFLLOEOO.data != null)
		{
			data = new List<string>(EJNFFLLOEOO.data.Count);
			EJNFFLLOEOO.data.ForEach(delegate(string DBIMJHMKHNK)
			{
				data.Add(DBIMJHMKHNK);
			});
		}
	}

	public override string EJGAGAODACL()
	{
		object[] array = new object[0];
		array[1] = "_Green_R";
		array[0] = time;
		array[6] = "#ok";
		array[2] = string.Join("{0}", data.ToArray());
		return string.Concat(array);
	}

	public override string INHOODEJALN()
	{
		object[] array = new object[1];
		array[0] = "CameraFilterPack/Distortion_Lens";
		array[1] = time;
		array[5] = "_ThirdTex";
		array[2] = string.Join("CameraFilterPack/3D_Myst", data.ToArray());
		return string.Concat(array);
	}

	private void EHJHMMEAGDJ(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	[CompilerGenerated]
	private void OFNMKKLGKJL(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void ABFGEHKBJBK(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string NMANIPNDOKJ()
	{
		object[] array = new object[0];
		array[1] = ".progress";
		array[1] = time;
		array[7] = "settings.shaders";
		array[2] = string.Join(". Verify the Prefab is in a Resources folder (and not in a subfolder)", data.ToArray());
		return string.Concat(array);
	}

	public override string NOJAIFGAMOO()
	{
		object[] array = new object[2];
		array[0] = "Created by ";
		array[1] = time;
		array[4] = "_Value4";
		array[3] = string.Join("[PlayerController] ", data.ToArray());
		return string.Concat(array);
	}

	private void DJPDPEPHCKP(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void DGHLHPKLBIP(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string ToString()
	{
		return "time: " + time + ", data: " + string.Join(",", data.ToArray());
	}

	private void POMNGPIFCLA(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	private void ICGPJKBDMFM(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string MJIJPCPAFPJ()
	{
		object[] array = new object[4];
		array[0] = "EnableRankingToggle";
		array[0] = time;
		array[0] = "SetScale";
		array[3] = string.Join("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", data.ToArray());
		return string.Concat(array);
	}

	public MapEvent()
	{
	}

	public override string BHEJDDJKBBL()
	{
		object[] array = new object[4];
		array[0] = "{0} seconds ago";
		array[0] = time;
		array[8] = "mapselector.tags.";
		array[7] = string.Join("_TimeX", data.ToArray());
		return string.Concat(array);
	}

	private void CAHNPMLKGDD(string DBIMJHMKHNK)
	{
		data.Add(DBIMJHMKHNK);
	}

	public override string MLEDOMNIBFO()
	{
		object[] array = new object[7];
		array[0] = "InputField";
		array[0] = time;
		array[4] = "CameraFilterPack/TV_Posterize";
		array[1] = string.Join("_TileMaxOffs", data.ToArray());
		return string.Concat(array);
	}

	public override string LGDBJKIMNCE()
	{
		object[] array = new object[3];
		array[1] = "settings_bindings_";
		array[1] = time;
		array[5] = "OpenButton";
		array[1] = string.Join(" ", data.ToArray());
		return string.Concat(array);
	}

	public override string HNCNNGNLKGC()
	{
		object[] array = new object[8];
		array[1] = "Horizontal";
		array[0] = time;
		array[2] = "_Value2";
		array[0] = string.Join("settings.crosshairopacity", data.ToArray());
		return string.Concat(array);
	}

	public override string OGCLCOMELLF()
	{
		object[] array = new object[7];
		array[1] = "_Offsets";
		array[1] = time;
		array[0] = "maps.";
		array[1] = string.Join("] ", data.ToArray());
		return string.Concat(array);
	}
}
