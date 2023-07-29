// RanksSystem
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RanksSystem : Singleton<RanksSystem>
{
	public class MapReplay
	{
		public List<string> playerSettings;

		public List<string> activeProcesses;

		public List<PlayerAction> playerActions;

		public string mapID { get; set; }

		public string mapHash { get; set; }

		public string playerSteamID { get; set; }

		public int score { get; set; }

		public int checkpointsUsed { get; set; }

		public float accuracy { get; set; }

		public int misses { get; set; }

		public float comboScore { get; set; }

		public float penalty { get; set; }

		public string started { get; set; }

		public string finished { get; set; }

		public float arcsDelay { get; set; }

		public string devID { get; set; }

		[SpecialName]
		public void MNNALKPIKMN(int DPNHODJHGJL)
		{
			_003CMMDKNNCMDLL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GKCGCAKMNCN()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public string INHBFHBPHEC()
		{
			return _003CJLPMPKAGJJM_003Ek__BackingField;
		}

		[SpecialName]
		public string OHJHPBNPLDB()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}

		[SpecialName]
		public void BAAIGBGEGNH(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int AHDCAJGNOBB()
		{
			return _003CMMDKNNCMDLL_003Ek__BackingField;
		}

		[SpecialName]
		public string OLNCPGEKJEI()
		{
			return _003CKPCNOKBIIOE_003Ek__BackingField;
		}

		[SpecialName]
		public float ADJFAJIOKBI()
		{
			return _003CGBELECOEGLP_003Ek__BackingField;
		}

		[SpecialName]
		public void CBFMHIONBNP(float DPNHODJHGJL)
		{
			_003CGBELECOEGLP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ALPBACEOLHK(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		public void LABLMLOLOLN(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			finished = DateTime.Now.ToString("Environment/SunBase_");
			score = EPLJLGAIJCM;
			checkpointsUsed = EJBAOLHHOEK;
			BAAIGBGEGNH(LODDNOOJFPA);
			KFLEHIHMIKD(FNPFEOPCHHJ);
			comboScore = NMEHALJBEFC;
			penalty = HKNBDMAPEHC;
		}

		[SpecialName]
		public string FBBNJPDPCOM()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		public void FinishPlaying(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			finished = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			score = EPLJLGAIJCM;
			checkpointsUsed = EJBAOLHHOEK;
			accuracy = LODDNOOJFPA;
			misses = FNPFEOPCHHJ;
			comboScore = NMEHALJBEFC;
			penalty = HKNBDMAPEHC;
		}

		[SpecialName]
		public void OEMPACFCAID(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MHLEJOCDAPI()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void JPFCOLONFEO(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KKPAGOGNLLN()
		{
			return _003CMMDKNNCMDLL_003Ek__BackingField;
		}

		[SpecialName]
		public void KFLEHIHMIKD(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		public void GEGLANKEMBP(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public string KPCIHJJFEHL()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		public void RecordAction(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public void KNNGFGPDGDG(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HKDPMHFDHLE()
		{
			return _003CJLPMPKAGJJM_003Ek__BackingField;
		}

		[SpecialName]
		public void ALIPKOCBIEH(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		public MapReplay(string CAFHKDIIDEE, string CNNLEIEFLOA, string KINNJOLFPCF, float CDDAEGKAHCJ)
		{
			mapID = CAFHKDIIDEE;
			mapHash = CNNLEIEFLOA;
			playerSteamID = KINNJOLFPCF;
			arcsDelay = CDDAEGKAHCJ;
			score = 0;
			checkpointsUsed = 0;
			accuracy = 0f;
			misses = 0;
			comboScore = 0f;
			penalty = 0f;
			started = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			devID = SystemInfo.deviceUniqueIdentifier;
			finished = null;
			playerSettings = new List<string>();
			List<string> list = new List<string> { "note.0", "note.1", "note.2", "note.3", "note.4", "note.5", "note.6", "note.7", "powerup.0", "powerup.1" };
			playerSettings.Add("bloomintencity:" + Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f));
			playerSettings.Add("cameramovements:" + Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f));
			bool flag = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			playerSettings.Add("hitsounds:" + flag);
			foreach (string item in list)
			{
				playerSettings.Add(string.Concat(item, ":", hardInput.GetKeyCode(item, false), ",", hardInput.GetKeyCode(item, true)));
			}
			playerActions = new List<PlayerAction>();
			activeProcesses = new List<string>();
		}

		[SpecialName]
		public void DJJAIHCMFLH(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IDEFLKNEHCA(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		public void KECKMCKFJLI(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public int AGGEANMACEL()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}
	}

	public class PlayerAction
	{
		public float time { get; set; }

		public string data { get; set; }

		[SpecialName]
		public string FHPLICNCMJG()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void MGGPHEFBLLC(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFDDODKOBKL(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GLFLPMLJAIP(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OEFMIIHJFNN()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string LINMBCLGDJC()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float MPJDEFGNDML()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float DPMEGFMKKHF()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void JMFCCIKLDGF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KLIBDEPDIBB(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string EMJFELHJBPP()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float EGKNIKKBMHG()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void ALJMCIEAOJJ(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float OKNHCNBMKNM()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void DINMEAALJLE(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HPKPBONNIIJ(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AAPHEONJOGN(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CKJBHFIFKEE(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JADGHAKGMAG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FOFFNHCENLG(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float HIPGCCOLOBB()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void DCFGJHIFBPE(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IKBDCPIBANP(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NLDPIACJDFO()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float OGAJOMAJJEA()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float GOBMLHPOMGH()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void DJBNHANOCCM(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BCINDAHCIHG(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		public PlayerAction(float EHHBHEJBHNG, string NOJGGCLPPAM)
		{
			time = EHHBHEJBHNG;
			data = NOJGGCLPPAM;
		}

		[SpecialName]
		public string BHBIKOHJFLL()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void PKKGKBDBLOM(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FMPANGMCDCG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float CAGPFDOGAEE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void FPDHPBKIPPP(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float NFHAEDENGFG()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void FAKBDKJNGLO(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float NKJLAHDNLGE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string IIFKHLLKHKJ()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float NKBENMLIAOG()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void HKHMFCGAIPD(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MJGCACEAPMP()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void IPMIGIKBBAI(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FLJHBGENNLG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DAIGFABFNDP(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NPDMBOIJNFP()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string HKJHJHOEPOI()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void JNNKHPDPKAA(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PEONMPPIDPB(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DPIAKBMCCKB(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BNEEHEMCOOL(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FEJBEAHFLCO(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FFAPEEBDLND()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void HHJHNMHDGMP(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OHOIHAJAECD(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float MLNCDABNMAB()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float ACJADDMBIOJ()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void DIFAHPKFMCB(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OIBFKLBKDIB()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string MIAHCJNCOEH()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void CENHKGFEJBF(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFDMLIPCDOF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MCHDGNHPCBJ(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float FMNDMGHADNF()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float HAELIPIDHFL()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string CHBGKJHAAPO()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string KIBFMCMMOOH()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string GIJIGNEODJH()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string CGFLCMMLGNF()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void NJOGBDFCCBG(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FFADJABEDOG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JHKHMIDNJKM(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float BOJHGCFKCAA()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void CLNPNGCGFEK(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CKDHANKHHBF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMEELLOIOAG(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float NLPPPEBNEJE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float KAGHNDMLIGC()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float MFFDNFIEBGB()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string MLKANPGNNFN()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string JJPHFEFDPFO()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string IHEBHELBJMA()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float CPEEHJGCCLG()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void CAGDCMFEOBG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float ADGNLKEKEEP()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float LOOKAPGLACH()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void LOKEMPIAHJN(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LIBDNBFECMC(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EFPECDECMAH(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float NMDOCAKCGKC()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string LHOLBOGGKEN()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void LJELCCEFFGM(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FIEOAADIFCJ(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string ADJKNCJBPJJ()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string POKJLHBLOJB()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void CCONNCMKCEK(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HKGBJNACLMD()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string PLIHGPHOJNN()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void ILBEMPPPEBJ(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEEEOMNNBCC(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HGBDMGFNDEM()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float JFKCAFGHIOE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float BEDGGEKMHJF()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float NHKLKCJEBLN()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void HDNCEHKKGMF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KGHJKEIBHKN(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BHLPGDMPHIM()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void GKAFABKGPDK(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class PlayersRank
	{
		public bool isDev;

		public bool isModerator;

		public bool isTeam;

		public bool isContributor;

		public int place { get; set; }

		public ulong steamID { get; set; }

		public float totalScore { get; set; }

		public float avgAccuracy { get; set; }

		public float avgMisses { get; set; }

		public string updated { get; set; }

		[SpecialName]
		public void FMJIHEDNCPD(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BLCEFMIHELL(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float KCFACDJDGLN()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public void KGDEDHLMOOF(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEGJMMDEDCH(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BPLGFNBPGBN(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JCDLILAFFAJ()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JIGCOIOFDNC(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float ANHKILGBOAB()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void PMHHCJJMJMA(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MNBGIHCKJCE()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public int IGKJJMCLABK()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GHDHFEEBKKI(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float OPILKKHHCMC()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public float BFOOKAMIAIJ()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void PMBKDIHAGJD(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IJOGIMHOGOF(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BANBLOKFLBD(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CJILPHFNMEB()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public float DOFKADFJBDI()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void DBNDBHBGPLE(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int INIGKHLOKCD()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MBONDLKMKGN(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MLLJGLFOOOI()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public float PFKMDOLEJBF()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void LCMOHCPLGGF(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PAPMJOFOIDJ(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ILINMDCFIHG(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NOEPDOGCBAN(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LOGEHEGDCEP(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DPLFGHEHGMI()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CCBBBFKMCOH()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void LCLLGHAMDKD(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LILJDHFLNON()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public ulong NOOGEIPEOIL()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void OCBEDPHDKMN(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFEKLCFGMCA(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DBENDNHIDGF(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong EPELCPMHCJC()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public ulong BBBKGKJKEGI()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public float EMFMNNCENOH()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CAFJNOHACPD()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public float IKPCOIGDIIP()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public string CHPLBLCNFBJ()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public float BMCKDNPALLJ()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public void JLBBIABGCOD(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EELDLHICDFI(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GBIBLLCEBBH(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong DOKGKLEGKDK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void HLDPFDLIHBJ(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AHIDNEHNLPN(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		public PlayersRank(ulong GDOHPDHLPBC, int JMICLAEOFNP)
		{
			steamID = GDOHPDHLPBC;
			place = JMICLAEOFNP;
		}

		[SpecialName]
		public float KPBEMENKEKG()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public float KMJIAFJJKBK()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void HPGOPDANNBO(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int IEOGJOLGLFI()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public float JMEMKFEIFJP()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public ulong PPMEPFOPHLF()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public float EGKFMLKFBIN()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void FMMKNCGHMBC(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AJIEPINMKDI(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float JGNNOLBBLJO()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public float EFACBBBIPHI()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void IDPBIHALGDJ(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KAANIMEJMAL()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public void OHEFIECEADL(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class RanksJson
	{
		public int page { get; set; }

		public int entriesCount { get; set; }

		public List<PlayersRank> playersRanks { get; set; }

		[SpecialName]
		public int BNIPNGIBGKM()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void ABJPJCOOGII(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KGKLBGMBELF(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HDLNDLANIFJ(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CEIMMHOPHKM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MPAADHJGNKF()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> OBPKEDIIPLI()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int JBNMBOJJDMF()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void HGAHJIINGGN(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FHHMPKOEDDO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BKOMPJLOHJN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> GHDNGAJMEEK()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void GNKBBPKIDPG(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JDHHENPFHAJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void IMJNAFCHGMG(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CALKPKGCALB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> MIJDLOEOOKL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void HFNBLPHBANH(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CHJBEBCIDMK(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int NOOJFAMHHBD()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int EKPKHNKFABD()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HIENMNHBJJK(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KMAICIKDDHD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JODJNNPECOE()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int PKLJGPINFKG()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int DLHNPOANIHA()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void ECJJNDGLCHL(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NLJHMABCDMJ(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayersRank> PHJMIHEFHPH()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void FAMPAGDDHDM(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DFLFOPNDOMC(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayersRank> DNNEHNKCECL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int GNFFKIAPIJF()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void PBMBDMKLAEO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GABKFAOBDGM()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> KKEPKPBCODL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void OEBLNBDLOPA(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int IGANOPJDONE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int HOHIMDBIBMI()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void NCEPLCMPIFL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HFMIJMMHBKI(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EJDLDBALNDD(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OLMHCNCHOHK(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayersRank> BNAMLDFHIGH()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void INMJANCPNEP(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DNDMKABEJLD()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> PGAMKOEGPEM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int MFLGOKACMFP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int NOEBBHNEFEA()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int BALJOLFOLHP()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void GBGKOFEPJMB(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AEDGOMJDCIH(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayersRank> OJCGOBPGGGM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> IMPMEFFJPIE()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}
	}

	public class FastPlayersRank
	{
		public int p { get; set; }

		public string s { get; set; }

		[SpecialName]
		public int MGOMOPDBMHB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string NGFMJOJHIKK()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int CNPFEGKOFGD()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string IAPPPJONJFJ()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void BDDLGAHPOPG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int ANKAMMNPKMM()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int DABMKCCEIGK()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void EPJKFGMIBNN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DBHONACDELD()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void PPMMPCNLFCP(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FNPLNODKKDM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JJIALEMJANE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int CODKKENEJCB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void AHKOLHNOBFM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PKPBEDBJFNI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string ONIOLBCHKPB()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void KJDEHAGHMCP(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DPOEPMBKKGH(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MOMNKJMOJEI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string HEIBABNFCAL()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string FCIMMGEHOPI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int CFOJLCEMKAI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string ALMDCOICPEB()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void COCMFEKEDEK(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FOLDOBGNHAG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KAIEJOIPHHI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int NPCGCHMEHJM()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void HNHDAPHKEEP(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int LMIKFNKEBEN()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void EBFMIOPJPKH(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BCMGDNOIMOE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string AOOKKECFMKM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int EAPHGJIKALP()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void GMBACHEIHGF(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HPGDIPJNKIB(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GONFKNAIAJH(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HFGMLHADFEB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string MNPEAOAJHLM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void FEHIDJHHNIN(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEFNJACHGBI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CBIOEGAPGCO(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KBIIIIAADAC(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FMLMJDKFPIG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KKAPCKGHHNN()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void LNCKCFMNOFG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LOPFHNBAOFP(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void INJJNMKJDMN(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OPCNLJKPIBN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFBFLFBGNBD(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEFICOMGDMK(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NIBABBHIMNI(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NAODOIFBPJO(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CECMEKMEBKM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KLCDMPNLGBL(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LOEHFKKAKFN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int OJCKHEFKMOI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void APCBJJKDFCK(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HFBFMDMMNNF()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void KEEHHILHMKE(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int AEDDILAJFCC()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string IEOKEHMPAIG()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int ADHHMAKDMAI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string FBNHKMECJAM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void BNNOMODCOGO(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int POMBJIFGLBJ()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void OPIEEAACMNN(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OGGAEFOBFFI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BOKFILKGABA()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int EHJKFMJGCDM()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string EDIOGHHEMCI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void EBLKFKIHLON(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MFAHAMJONMI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void LMKHDHPOBDN(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BJOEKBPNMMF(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EHPEACMNGOG(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void COIGEHFNLFL(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JDODCEDNDFH()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void OBGALFNKMCJ(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PNOHOOAAJPJ(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HPKOEJCIAJI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}
	}

	public class FastRanksJson
	{
		public int entriesCount { get; set; }

		public List<FastPlayersRank> playersRanks { get; set; }

		[SpecialName]
		public List<FastPlayersRank> IMPMEFFJPIE()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void MCNKKBOAFJN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> NMKJLLNFFFP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void DIGLPMDODML(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EANHIOMELKB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> PHJMIHEFHPH()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void ODEAINLJBFH(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFBIHPDGGOK(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void INMJANCPNEP(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IGEBIKDNLCP(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> CEDHOLJIKEP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int BJJGGIPAJHA()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int MFLGOKACMFP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int HKGKLAIBGGN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void PJBACNPGHNJ(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DDKKOCHPMLK(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JOCOONDJMGD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> CPMLMOPGNKA()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> KAPIGGCPNGO()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> EMFMOOHPPPM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int CMJMJPHJGBA()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int ADAPEBKMNMM()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> DEFEIGKLBKF()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int KMEJCPCEPLI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void AEDGOMJDCIH(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNAOKKLFNCC(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> HLKPJDLPMFL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int NOOJFAMHHBD()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void IMPEHAAFAJF(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCLHEBAKBLL(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IMJNAFCHGMG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JEDIFHKCDDK(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GBHICOCNNCK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> GHDNGAJMEEK()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void KPMCNDNCGGN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> LPNJPCGCJOB()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void MOHKIBKFOMI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HAJPFHOELAP(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EOEDPGEFGBF()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void LFCDIBDICGC(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IMPJCGGONNG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JBKFJHEONMO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> CPDFCCBOBHC()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void LKEJFBDMPIE(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class TeamJson
	{
		public List<ulong> devs { get; set; }

		public List<ulong> moderators { get; set; }

		public List<ulong> team { get; set; }

		[SpecialName]
		public List<ulong> HNKGJAGCENO()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> CIHCMHOKDAM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GNJMFNBKFOC()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> JKLNGPHHGNF()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void DLLEAKEECCK(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PDNGDPBCHDB(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> BEOFLKLDBAG()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void MFOLKPIPMDL(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HOFBFNMJBDG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> LMJEDGFGBAC()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void IBNONPEHMPG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BDGLPIPELEP(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BHMFCEAILME(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> FFNOMACLKIF()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> FNPKHLNJKJK()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GCIFDCHHNMP()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> HGAHOOLIBKO()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void ACEACMDHHLH(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CIPMEPEMJCG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> CNPLAHCAMHC()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MHDCENBMFGA()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void FGAILFAJCKN(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> IEGPBCBEBHM()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void GJOFJHIEBFI(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GOENPNNGAGG(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> JICAOJIIOPJ()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> JKAGOHGELIJ()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void KHDOBEDFGDK(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> OAGKCIGLNLH()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> FAJMKIGABJP()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> HPBLHNKPAJE()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> HEFNILELGLE()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> PAJKHEKEHEM()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GLOOBBMBPBP()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void HBCEBKGMDLI(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> ENJLPADECIG()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> INJNMMBFLMI()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MAGMLNIKPAJ(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> IDCHOIOHHBD()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MAAAOALGJAJ()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void PKLBAMMGGPB(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> PKNCMEKLCOH()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void KNHFHLEKCGE(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CDDEAKNNABP(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JCLPAECOIJG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JHPOGBIGEAF(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OPBGODDOAHC(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> JNHKJFHFBIG()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> CEMCEIHCMIG()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void KLOHLCFDKJC(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> AEBNCELLMII()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> DLPPCHADGIB()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> DABFJHPANGH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void CCEDNLBCJOG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> JEFEEHMMCIN()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> HGBHJDBCBFP()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> JFOGOMAABDM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GAOEAIJNBEO(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NEKBPBAGMLO(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> PBIPKOIHKNH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void IMAGGINNINH(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GPGOBNDJOKP(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BAMDJEPCKIB(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> GBPLMGJKPJH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> DIGAGOGDPOK()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> IPEOPAHNCAM()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> IOICHPNKCDD()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void GOICOPFIICE(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LNBKMMCEIGA(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PPDPBIMGMNG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FIHNLNKEKEO(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> NAEHLCMDEOH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> AHEFKNKBFJB()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> DFFMADGLMAK()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void GELLNOAMGOF(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MAJHAFBKPBL(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> GMKOEKMEDFH()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GMOFCNDFBHO()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MECBOMHPAKG()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GODJHFCIBAB()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> IGDJMMJEHNL()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> ENPCNGNLPLH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> NIPAIBOHJFI()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void AMAHCLGIOAN(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> BPCBBDLODAH()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void ELODLACPDHC(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> OMGFMLALHJA()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MMKDJJLELAK()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> KNLJMOGBLDM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> ILPFDHLPJNA()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void KJCGDHBMNGB(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AJCHOKKCLEA(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> CGJKNIBIJMC()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> OMPOHMNPHOP()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GGOFACIOFGI()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void NCGPJFPOKFM(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> GAJGEDPJLCA()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void CEDIFNOFJPP(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> NDFMKNACOII()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> KHJGMNKCAKB()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OPKNNOPGBLJ(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> FBGLHEKKPMC()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void NCMNAKFMPPG(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FCEMLAOPKIH(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> EJJOECMPOGC()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void AOAKLEMCCNK(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> MFCCBJCNOJJ()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> FFCEABNMIOF()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> EECPPGHFGPL()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void NBBNHIKLOKJ(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FLAJOLBDFFD(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> LBKPLIGICLN()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> FMFGNCDJHGB()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MJGPLDNFBLI(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> OLHJPKHLJII()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void LCBLLLJBMIA(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PJHMIPKDCBE(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> NHFELHOOPOA()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> DLIMIFBBLGM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> IPBFJPCBCGM()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MLLDDHHLAEF()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GFOIJNHHIAN()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> EELBOHOJKIF()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void HFDONCBOMAL(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> ONHKHPCNNID()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MOJHODKLCBC()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> CCDIHLLMBIO()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}
	}

	public class Ban
	{
		public enum BanType
		{
			Warning,
			Mute,
			Temporary,
			Permanent
		}

		public int id;

		public ulong steamID;

		public string date;

		public BanType bantype;

		public string until;

		public string reason;
	}

	public class BanListJson
	{
		public List<Ban> bans { get; set; }

		[SpecialName]
		public void IBBFILGBCHO(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PLLIMICKMGM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> NOFIMPLHFGF()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void BAHBBADLOEP(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LIEEFFBJLFG(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> OIIMIBLNJFF()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void JPPLDAIJGCD(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> LNKHIFBJNBP()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> FIHFNMHBAIG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void LBLHNGMLLAO(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BGEBHEDNBDB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PJKOCLDEDFE(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JKKOCNNBGII(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KCIOIKKOOMM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OIMJACHDEND(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AHMDBKJBDPF(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MBMEOIMKFGB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> HLCHCGJBLDG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void CPAFOIHDLOH(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> JHBOOBBMBNA()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void EGECMIHMOFN(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AIIAOLGFNMB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GCIHNGLDIDL(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PDONOBPIKMB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> PLJNEIOJFJK()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void OEOHNFELNJF(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEDHFANODHL(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HMJKILGEKAJ(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> JPEBPOAFICH()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> AKMEGMGPKLE()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> NAGCNNDNFOI()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> PNDEGLGJKEG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void NCALIDOPPBJ(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNAIPMBDLIA(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IIDEBBMMOOB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> NPHBCLINAEG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> HGEPBAEMEIO()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> NFMDJKFJHHI()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void PNAKACJFACE(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CFDNEAIJGIM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> IJHBHHLFMNG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void CMKLIIHPBBK(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> NHALPPIMOJJ()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> GCGHGPEEFJL()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void DIFPJDJOANM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> CHCOPNNJNBL()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> PBGPEHPEJCF()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> PAGHLAELOOI()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> CHKPKEFMOBG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void LFFDPAFDIGA(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MAGEEJHGKMB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DGDEIGHOIAD(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GPFOKENEMGN(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> ANAAAHFGFND()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void NNKFIGPFNOJ(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> INEBLADCMEM()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> BNCBPEPDLHG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void CBFGKLPEGDA(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> ODFHABLOGMO()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> NLNILPHFKKP()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> PEFHOFHOFLM()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void BJGAMECOCGA(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> MOJKMKGNKIN()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> IEIGIFMEICA()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void HBKNMGALNLC(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> GEFBPFICMHL()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> KFPDFANBKFB()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> FHFLGMNPILE()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void CGGLJMMOCOP(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> MCBCHJCKHCA()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void EDBMFOOIGIP(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> JJLPBGJAMIK()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> IBNDABGKNAH()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> FODIKILGPFF()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void PKDEKEJOKNG(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCOLGJLMJKB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EBFEHOKCNPH(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> GDEJALDAKIC()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> CAKIGBHJJFP()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}
	}

	public class Map
	{
		public ulong id { get; set; }

		public string hash { get; set; }

		public string added { get; set; }

		public float difficulty { get; set; }

		public bool isLoved { get; set; }

		public bool isFunny { get; set; }

		public bool isOfficial { get; set; }

		[SpecialName]
		public void CIHAMBAFIIO(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMMGPJFLJAN(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NCOJBPAIBDJ(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ILJAIHNONEG(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NMKGCBJPJHL(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool BJBPMLKECIA()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public string LDDDNPEHCEG()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public bool BOPKDBILIEA()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public float JEKMHHCPHCN()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void GJBLMBPFGNP(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string PPHIDEJBJGM()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public string NPEJINEIOCF()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public string AGPPOOGOKJC()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public void FKOBHMCHPEI(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool AIGLNDJJPFL()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public ulong KCGOFGJNCME()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public bool MKLAMAFMEPF()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public void NBIFMJNFFJO(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong CEEKAHOMGKG()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public bool FNDFNECFNEL()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public bool AMJIEEIMBDN()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public void GCEDDGGPGFP(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PNDFMMENCMD(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BADDMKNNCGI()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public bool JMMAPHACFAG()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public void DDGEEKHCBOF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KJMICPMGAPD()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public bool CDPELGPJPND()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public void EDPDFMCOEPC(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float MBAFCIHCIOM()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void LEMCHELEEBL(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DFCNJMKCGHO()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public void IOKCGFNOEBG(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void COLBOOOIBCD(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float BAFALKHFFMK()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void DIPPGAEKPMK(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LOLIDCAGOJO(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool GPAPLIKKEOH()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public bool MEFGLBKEHJE()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public ulong GOMJAEIDHNM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void GMCINLCADOC(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string ANPFFHGKIPB()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public void MBFEHFELDMD(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float NNDFIJEBENA()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void BOAAFPFJLDH(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NIENNNPBBLN(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HAAEJNLHGMK()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public string JIBONFJGLKN()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public bool DKHGLGJAKOF()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public void KHIJPPDJIDD(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FJEONOMKAGF(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool BMKGKMJPAMF()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public ulong JGEBJGHEJPK()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public bool KFMNMCJFPPI()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HJPGIGBFCID()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void KKEMCHKBOIM(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PILDNHHJALI(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FJMBGIKFEME()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public void FKHKGBMHBHE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool MOEOCIODBDH()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public string PDHMMOCHDAJ()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public void GELHMIMICJD(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float GDCGLBBAJHN()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public float DEFJMFBIGIM()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public bool GCLPAFADHMD()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public void LHCKCMBBBPH(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFMDKOMJBLB(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool CILAHEMDKNO()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CHDCIFPPIFI()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public float IFMFDMKFJBI()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void GKENDAENHGL(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCAKPOOEHCA(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ONCAHBANIAN(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool FLPLDEMKOFN()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public void EFNJNOEBKMO(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BLGFMGLIOFN(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FAMOCMOFODI(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool OOFBBOBFPIH()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public float PJBPOLLEJFN()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void AGGGMKDPKJH(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool NPFHGDJAMPK()
		{
			return _003CAHMCLGDNEOE_003Ek__BackingField;
		}

		[SpecialName]
		public void OKOPKJMDNGA(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBFNMBEFDHN(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class MapsListJson
	{
		public List<Map> maps { get; set; }

		[SpecialName]
		public void GAFGJLDJCGD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OBDLCCNAJDA(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DIAGAHGDCIP(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> MGCLENCJDKC()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void DKFKEMGEFHD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEMHKBMMNDE(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> BIFHHDJDIPF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void FECMGMDBIAF(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JDOGPMLHKLI(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MNEKFJGJPEE(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> NHLCIPAEDBK()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> JHHDJMKILHH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void CPPCOPEDNAJ(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EPMMEFGCCMP(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> CDINIEMCHCA()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void DKCNKLHBFGD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BFOKNMJGKAC(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> MIGBOJDIIOF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void ALHJJHMKIFG(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DBGCPDKKKOH(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MKPMMJCNPEM(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DIGGHMLHFFM(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CDDHDBDILGA(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BJNPDMDDEIF(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BLDLCGJKKEM(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CLGLJCGNJFI(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BHBFDIHCDLI(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> CIHFCCGPLPF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> ENDKCFKIOHD()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void AJDMLBHGBAC(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> IDFKENODONK()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void ODOBIEMGJAN(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHDACLOAGEL(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> CNOKMFEGPOD()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> KKBCDFPKOMB()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void HFNFJJBAOBP(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EGHHOMOHALD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HMBFIAGAIDJ(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> FHCLMKFHANC()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void BGBLFJDIFIB(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PACFCCHFFHE(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> KOHMFBCJDMH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void CAPLJIHIIID(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NCDJMDFNCHP(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class Score
	{
		public int place { get; set; }

		public string steamID { get; set; }

		public int score { get; set; }

		public float accuracy { get; set; }

		public int misses { get; set; }

		public string date { get; set; }

		[SpecialName]
		public void HFLMAPBJDAP(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JBKEBFBCHAK()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OMBFGMMELHL(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LMHCKKPBCEJ(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HBKDJICGCGJ()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OHEFIECEADL(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJKMEBCLLGG(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NAKOJLJKOBP(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFAFIGCBKNE(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FNHHKHACPAM(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CPDCGPAHIGA()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void BGKKADIEFEF(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DCMHLKONEPE(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GNKCJEBHCKN(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KCGPEDCMDHA()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MDBNEKJMPPJ(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PINMMDCFJGI(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BLHKAJBLHCD()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public float IMPANHLMOIH()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void OMGMLKOGLFJ(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int LBKPHDHBLEH()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void BEPEFAIOMKH(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string EFEMONFHGDB()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public int OEIGOCIFIGO()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GMHMMCNPAJL(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OOLJMMKLIGL(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ODKHOHEKPEG(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int NNJHIAPEALJ()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public string DBMLLBMLDFE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void LMACEOGHOOO(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FBKDBPIILAC(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JAIEFLFNNKD(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PIJKMCNCAAJ(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float FLMIJFCFNCL()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int GDDOBNABDNE()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public int DNCEOPEHEID()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void DGEBOFDFHAM(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JPCLCMDINFD(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BJKHJGIIBHL()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void HIMBMOBJMBH(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GLMIGICOHAC(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CNDMCBLCGFJ()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void DNMNKHNPJDB(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FMBFCMOKBJL()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OJHHGJKJNAJ(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DOBGGOILPPO()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public int BLMDEGCCCFD()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void PABLALFBLBB(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CAOIJCDJOOM(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CKCJIDMHJDO(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CGOKNLBMIJB()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public float PCDCMGOBHOD()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int GJPLIDHMEEJ()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void HJJICJDKILE(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string GECMOEAHKPG()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void JHKJAAKBFMO(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FDMODBMKMKG()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public int DIFFOAEBLFM()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void ENDHHBBADHB(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KLGFCKKNNOF(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int NGIGIFCEFDF()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JKGKFLJDPKA(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LGJPIKFGCII()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void KHDHCPMNOFP(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EBABCEKKEGG()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void LKHNACCELNN(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DOLCPECPMNH()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void IFNEOHEOCIL(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class MapLeaderboard
	{
		public int page { get; set; }

		public int entriesCount { get; set; }

		public GameScene.GameMode gamemode { get; set; }

		public string mapID { get; set; }

		public List<Score> scores { get; set; }

		[SpecialName]
		public void DKFFHJOCEDE(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int PMCCOICGALB()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int ECOCGNKEIKD()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int DLHNPOANIHA()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int KBFPAGNKLGK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void CDMIAFPINFH(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KKOGFPCIOBB()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public string FNFEEMHHKIK()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public int ELKLHCBICPJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void MJEAEAEINLA(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EJNLBMAJBBF(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HFNBLPHBANH(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IBBECFNAMBJ()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void AIHDJIAKAAF(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> JCNHHFKDCCK()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void IHEPHLDBIBN(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KKOJAPEGKOM()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int JINCANAFNFA()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void HGJNEFBBOPD(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OKGKPEGFEJB()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public int BJJGGIPAJHA()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public string LGGBBFNLIME()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void LDMHOMIEAAB(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NLAIICLPPHD(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> EOFGFGDPKDO()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void EJAIBANAOLA(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FAOLENHKKLN()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void IGHANDGBMOL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BNIPNGIBGKM()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int DNJMBGODJCD()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void FOKDDOEEMDO(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OMLEILFEGFE(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GPFIJFFFBJO(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> LCDMFGOPFEN()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void KMPPIAMLNKJ(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BALJOLFOLHP()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void AODLKOONJMM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IGLKLDHKFGO(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OFBAIOAEKME()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public int MHBNAEOCMOJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void JOCOONDJMGD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHKIMJJEFMM(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ANDDLPMJFOK(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public GameScene.GameMode IGHJPDJCJAA()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public void MDCFACNFCME(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JJBBMBEKNHO(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MMANKFAMNBL()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int BEEHKENLHNI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void KLKLNCDCEFD(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JKPGMGGCNCJ(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FJDGAMAHJEL()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void ALIGHCEJKNF(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EKPKHNKFABD()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public GameScene.GameMode IAMGBKGLLBJ()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public int GKBNMAGHDMP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void IMPEHAAFAJF(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KMEJCPCEPLI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void MEHOFHNNKCN(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public GameScene.GameMode GBFKCKOCIGL()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public void AEDNDCPEMIF(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BLMGAHICCFE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<Score> FJEJKNAMOJD()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}
	}

	public class PlayersTipsJson
	{
		public List<PlayerTip> tips { get; set; }

		[SpecialName]
		public List<PlayerTip> MJKCFMJEIFG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void KIIHGOCALBE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> HDJKGGDBEPA()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void HDCEEDJLOEO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LDILNAOELGO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> NBLIFLKGMNH()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> EJGCBCAIFOL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> GNPAOPOAPAC()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void ODICHKMHBEG(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> FLIOJNMBLNL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void ALCIJFHONFN(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CPOMOHJAEKM(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LDGIBMJBPID(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NBFFBPBMBFO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> PAJNMEJPPPC()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> NCEHNDDLIEG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> AFPPFBKNBOG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> GFAKCBIPMLC()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GBOLBALHHPJ(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> JNBKELJKIKG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GBADDOBDGPD(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EIDDOJODJAF(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> APKFNPGCNLD()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void BOOHJEDFCCJ(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> JJKFMPPOKMJ()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void DKHFFKGLMLE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> LEOAONFEILL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> MCMCGEAHFIB()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> FPPJGPNKNJM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> PAPPKBKALND()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void HKCAHENEHPD(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HJHKPBFPGKI(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MINPGCNMEEE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> NNKAFKOPEJG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OHNILHBJPFO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> JMGFFOJLMNA()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void PPCIDPGOGKG(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> BMFPIJACAJM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> EGNJNEMBFPA()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OAFADDMOHIH(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> CENEHJAOEOO()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void HDOIKFDPLLE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> MFKFCIONKCM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> NDIGPPLAIJH()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> IFIOFCMOHAM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> OEPILNNNEIH()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JEEEGKDNAOP(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LKKNGBHNDMM(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> BACGHDICJOM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GLPLNBNBAAN(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> DOAKMNDIAPP()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MJFEMECKIII(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GCBCBDMOKFH(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> HBIAKHFJBBF()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OAADMIBFHJE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> BEBHFKGOIOL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> FNAMEDDIEJJ()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> ODIJAMIABJM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void EKHGLIIKKMG(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DNBIDJDIKLG(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class PlayerTip
	{
		public ulong id { get; set; }

		public string tip { get; set; }

		public ulong steamID { get; set; }

		public string language { get; set; }

		public string votes { get; set; }

		[SpecialName]
		public ulong GOKADDKEMFK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		public int NNLHLJDEMEA()
		{
			int num = 0;
			try
			{
				string text = HOHOAOGHFDO();
				char[] array = new char[1];
				array[1] = 'ￒ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[0];
					array4[0] = '\u0004';
					num = num2 + int.Parse(text2.Split(array4)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string MKLBKIJOGBG()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		public int GetUserVote()
		{
			int result = 0;
			try
			{
				string[] array = votes.Split(';');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text.Split('|')[1]))
					{
						result = int.Parse(text.Split('|')[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public ulong LKKNPEBMCHA()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string IHGKNCLFHEP()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void IHENCDKCJNB(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IFPLIBFLOOM(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		public int PKHPADAEJEG()
		{
			int num = 0;
			try
			{
				string text = FHMMOHLGLOL();
				char[] array = new char[1];
				array[1] = 'ﾜ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = '\uffc8';
					num = num2 + int.Parse(text2.Split(array4)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void BHHEEGGLADG(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong IHGAFOAMKAD()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public int OGIHMBKNFAC()
		{
			int num = 0;
			try
			{
				string text = FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = 'ﾁ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('\uffef')[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void ADEANDNCNLF(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MIDAMGAGFIA()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public void KEKDDPICPDK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		public int BAKGBEGKGFD()
		{
			int num = 1;
			try
			{
				string text = HOHOAOGHFDO();
				char[] array = new char[0];
				array[1] = '\uffc9';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = '\ufff8';
					num = num2 + int.Parse(text2.Split(array4)[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public int EIBIDABNHLP()
		{
			int num = 0;
			try
			{
				string text = FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = 'ￕ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					int num2 = num;
					char[] array4 = new char[0];
					array4[1] = 'ﾘ';
					num = num2 + int.Parse(text2.Split(array4)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public ulong IIPMMNJPGMA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void KMLNCEGPDEL(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JPKPKHLJDDK()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public string EBEANLDNDHL()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string DNEGFHNDOKP()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string BIMMNOGPBBO()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void CKKHEBBKMPD(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong OKFOADGNODA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public string FHMMOHLGLOL()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string DOMCGFLKBIM()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string MHGCKABGGCB()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int LKHKLECGPFD()
		{
			int num = 1;
			try
			{
				string[] array = FHMMOHLGLOL().Split('ￎ');
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text = array2[i];
					int num2 = num;
					char[] array3 = new char[1];
					array3[1] = 'ￎ';
					num = num2 + int.Parse(text.Split(array3)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public int GetRating()
		{
			int num = 0;
			try
			{
				string[] array = votes.Split(';');
				string[] array2 = array;
				foreach (string text in array2)
				{
					num += int.Parse(text.Split('|')[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string FDLGDAJGABF()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int PIBNHCNPMNM()
		{
			int result = 1;
			try
			{
				string[] array = HOHOAOGHFDO().Split('￼');
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text = array2[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array3 = new char[0];
					array3[0] = 'ﾵ';
					if (num == ulong.Parse(text.Split(array3)[0]))
					{
						char[] array4 = new char[0];
						array4[0] = 'r';
						result = int.Parse(text.Split(array4)[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string DFPAENPEGGM()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public ulong OEHGOHJGENG()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		public int JLIKEOFNCPO()
		{
			int num = 0;
			try
			{
				string text = FJICLFAAFNM();
				char[] array = new char[0];
				array[0] = 'ￕ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = 'ￅ';
					num = num2 + int.Parse(text2.Split(array4)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void NAOEEBAEGDJ(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		public int GECKLJLICFP()
		{
			int num = 0;
			try
			{
				string text = votes;
				char[] array = new char[0];
				array[1] = '\v';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('\uffc0')[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public int CDCIANGOJLC()
		{
			int result = 1;
			try
			{
				string[] array = NJKPMJKDOMK().Split('\u0019');
				string[] array2 = array;
				foreach (string text in array2)
				{
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array3 = new char[0];
					array3[1] = 'ﾑ';
					if (num == ulong.Parse(text.Split(array3)[1]))
					{
						char[] array4 = new char[1];
						array4[1] = '\uffbf';
						result = int.Parse(text.Split(array4)[1]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public void CAAKCCHPHOB(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PELBIOCEALB(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MNHHIGAFBEM()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int FBIJLICDDFD()
		{
			int num = 1;
			try
			{
				string text = CNIIOBIAONN();
				char[] array = new char[0];
				array[0] = '\u0016';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					int num2 = num;
					char[] array4 = new char[0];
					array4[1] = '\ufff4';
					num = num2 + int.Parse(text2.Split(array4)[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void AAOIBICPOIK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		public int PFHBHDDKINJ()
		{
			int num = 1;
			try
			{
				string text = NFHDFIILPEE();
				char[] array = new char[0];
				array[0] = ',';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('k')[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public void EHGCFDCPLCP(int BMAEINMDAFF)
		{
			if (AJMEEPGHOAH() != 0)
			{
				string text = string.Empty;
				string text2 = DOMCGFLKBIM();
				char[] array = new char[0];
				array[1] = 'ￇ';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[1] = 'ￍ';
					string text4 = text3.Split(array4)[0];
					char[] array5 = new char[0];
					array5[1] = 'ﾪ';
					string text5 = text3.Split(array5)[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[0];
					array6[0] = text6;
					array6[0] = ((text.Length <= 0) ? string.Empty : "settings.enablehitsoundsinnormal");
					array6[8] = text4;
					array6[1] = "The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.";
					array6[5] = text5;
					text = string.Concat(array6);
				}
				BIOBDKHCFIB(text);
			}
			else
			{
				object[] array7 = new object[2];
				array7[0] = NJKPMJKDOMK();
				array7[1] = "float,0";
				array7[5] = BMAEINMDAFF;
				array7[1] = "\\n";
				array7[7] = SteamUser.GetSteamID().m_SteamID;
				AIAJMCKBLKI(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(JJKDAFNCDIF(), BMAEINMDAFF);
		}

		[SpecialName]
		public string BFIJMABPKOF()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string IAAJFBECEOA()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CIBGICHFIME()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		public int HEDKODDNFEA()
		{
			int num = 1;
			try
			{
				string text = FJICLFAAFNM();
				char[] array = new char[0];
				array[0] = '2';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('(')[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void EPPPFMHNCKI(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JJKDAFNCDIF()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public void DLBDGKKCEFO(int BMAEINMDAFF)
		{
			if (IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string text2 = DOMCGFLKBIM();
				char[] array = new char[1];
				array[1] = '3';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[0] = 'ￎ';
					string text4 = text3.Split(array4)[1];
					string text5 = text3.Split('ﾂ')[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array5 = new string[2];
					array5[1] = text6;
					array5[0] = ((text.Length <= 0) ? string.Empty : "_Value");
					array5[2] = text4;
					array5[0] = "_Blue_C";
					array5[2] = text5;
					text = string.Concat(array5);
				}
				AIAJMCKBLKI(text);
			}
			else
			{
				object[] array6 = new object[8];
				array6[1] = FAGKKOIOALB();
				array6[0] = ".lastCheckpoint.currentCombo";
				array6[3] = BMAEINMDAFF;
				array6[6] = "OK";
				array6[7] = SteamUser.GetSteamID().m_SteamID;
				PELBIOCEALB(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(id, BMAEINMDAFF);
		}

		[SpecialName]
		public string JEEGBIGEJMP()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public void HCEOMMIJOFO(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		public int GIGDJNPBFNJ()
		{
			int result = 1;
			try
			{
				string text = MIDAMGAGFIA();
				char[] array = new char[0];
				array[1] = 'R';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[1] = 'p';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						result = int.Parse(text2.Split('ￚ')[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string ABPAKJHNIPG()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string COEFMOFKOJE()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void PINMMDCFJGI(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MHKPAIMLJHH(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AIAJMCKBLKI(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		public int DNLGIMEFFDC()
		{
			int num = 0;
			try
			{
				string[] array = BFIJMABPKOF().Split('[');
				string[] array2 = array;
				foreach (string text in array2)
				{
					int num2 = num;
					char[] array3 = new char[0];
					array3[1] = ']';
					num = num2 + int.Parse(text.Split(array3)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string DBNAGAOOGPO()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void HCMBNLCNBGF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FFGMCNAEAKH()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void LJKJLEAAMJN(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		public int IGJGHMHMOOH()
		{
			int result = 0;
			try
			{
				string text = MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = '8';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text2.Split('ﾜ')[1]))
					{
						char[] array4 = new char[1];
						array4[1] = 'ﾟ';
						result = int.Parse(text2.Split(array4)[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string IKOLPBDKHIN()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong DBMLLBMLDFE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string NJKPMJKDOMK()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		public int FEDBIGMAHEA()
		{
			int num = 0;
			try
			{
				string text = FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = 'ﾸ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('Q')[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public void KMJBGNACIED(int BMAEINMDAFF)
		{
			if (CMIDMJKBAGJ() != 0)
			{
				string text = string.Empty;
				string text2 = MIDAMGAGFIA();
				char[] array = new char[0];
				array[0] = 'U';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				foreach (string text3 in array3)
				{
					string text4 = text3.Split('(')[1];
					char[] array4 = new char[1];
					array4[1] = 'ￎ';
					string text5 = text3.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array5 = new string[1];
					array5[1] = text6;
					array5[1] = ((text.Length <= 1) ? string.Empty : "2hands");
					array5[1] = text4;
					array5[8] = "Apr";
					array5[6] = text5;
					text = string.Concat(array5);
				}
				IFPLIBFLOOM(text);
			}
			else
			{
				object[] array6 = new object[6];
				array6[1] = MHCBHFCPKCD();
				array6[0] = "CameraFilterPack/Oculus_NightVision2";
				array6[7] = BMAEINMDAFF;
				array6[7] = "workshop.";
				array6[8] = SteamUser.GetSteamID().m_SteamID;
				BIOBDKHCFIB(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(id, BMAEINMDAFF);
		}

		[SpecialName]
		public void JEJMPBHEODM(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		public int KJDIFACCLFL()
		{
			int result = 1;
			try
			{
				string text = FAGKKOIOALB();
				char[] array = new char[0];
				array[0] = '\v';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[1] = '￢';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						char[] array5 = new char[1];
						array5[1] = 'ﾸ';
						result = int.Parse(text2.Split(array5)[1]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		public int LENKEOHCLKM()
		{
			int result = 1;
			try
			{
				string text = FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = 'h';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[1];
					array4[1] = '\uffd0';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						result = int.Parse(text2.Split('\ufffb')[1]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string GNGMJGFIKGD()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong NOKJFJDPHDJ()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void BIOBDKHCFIB(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		public int KJDDPBDIEGD()
		{
			int num = 1;
			try
			{
				string text = MHCBHFCPKCD();
				char[] array = new char[0];
				array[0] = 'ﾻ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[0];
					array4[0] = 'R';
					num = num2 + int.Parse(text2.Split(array4)[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public int AJMEEPGHOAH()
		{
			int result = 0;
			try
			{
				string text = CNIIOBIAONN();
				char[] array = new char[1];
				array[1] = '\u0012';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[1] = 'ￜ';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						char[] array5 = new char[0];
						array5[1] = '￪';
						result = int.Parse(text2.Split(array5)[1]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string MHCBHFCPKCD()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string PIOIINMGAOP()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void CDDGMCLMPEG(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		public int HKBLIMCKKEH()
		{
			int num = 1;
			try
			{
				string text = NFHDFIILPEE();
				char[] array = new char[0];
				array[1] = 'ﾅ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[0];
					array4[1] = 'ﾩ';
					num = num2 + int.Parse(text2.Split(array4)[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string IHDFNLLIHPN()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string JACPJLIGEOP()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public void PDGNODHEFOF(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NFHDFIILPEE()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public ulong CNOJOFMOEKP()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string HLJJDODBJMN()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void JIEOJEMCABN(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong LHDHLDLEACP()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void EHPNOPLMJCC(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FAGKKOIOALB()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public void PMHHCJJMJMA(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BILPCBEPEFH(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		public void PKCJEJBPKOE(int BMAEINMDAFF)
		{
			if (PIBNHCNPMNM() != 0)
			{
				string text = string.Empty;
				string text2 = BFIJMABPKOF();
				char[] array = new char[0];
				array[1] = 'D';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[0] = 'ￚ';
					string text4 = text3.Split(array4)[0];
					char[] array5 = new char[1];
					array5[1] = '\uffdd';
					string text5 = text3.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[0];
					array6[1] = text6;
					array6[0] = ((text.Length <= 1) ? string.Empty : "0");
					array6[1] = text4;
					array6[7] = "_ScreenResolution";
					array6[2] = text5;
					text = string.Concat(array6);
				}
				BIOBDKHCFIB(text);
			}
			else
			{
				object[] array7 = new object[2];
				array7[0] = NJKPMJKDOMK();
				array7[1] = "_Value2";
				array7[1] = BMAEINMDAFF;
				array7[5] = "#no";
				array7[0] = SteamUser.GetSteamID().m_SteamID;
				BIOBDKHCFIB(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(IIPMMNJPGMA(), BMAEINMDAFF);
		}

		[SpecialName]
		public void NFAAADLGEGI(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FJICLFAAFNM()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		public void ACBCECFHCIO(int BMAEINMDAFF)
		{
			if (KHMMMHMDFNF() != 0)
			{
				string text = string.Empty;
				string[] array = DOMCGFLKBIM().Split('X');
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text2 = array2[i];
					char[] array3 = new char[0];
					array3[1] = 'G';
					string text3 = text2.Split(array3)[0];
					char[] array4 = new char[0];
					array4[0] = 'ﾘ';
					string text4 = text2.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text4))
					{
						text3 = string.Empty + BMAEINMDAFF;
					}
					string text5 = text;
					string[] array5 = new string[5];
					array5[0] = text5;
					array5[1] = ((text.Length <= 0) ? string.Empty : "MenuRecordButton");
					array5[8] = text3;
					array5[5] = "OnAwakeRPC";
					array5[7] = text4;
					text = string.Concat(array5);
				}
				NAOEEBAEGDJ(text);
			}
			else
			{
				object[] array6 = new object[2];
				array6[0] = NFHDFIILPEE();
				array6[1] = "_Value7";
				array6[0] = BMAEINMDAFF;
				array6[4] = "MapConfig";
				array6[8] = SteamUser.GetSteamID().m_SteamID;
				IFPLIBFLOOM(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(JJKDAFNCDIF(), BMAEINMDAFF);
		}

		public void JFMDLDIGBHE(int BMAEINMDAFF)
		{
			if (IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string[] array = FHMMOHLGLOL().Split(',');
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					string text2 = array2[i];
					char[] array3 = new char[0];
					array3[0] = '}';
					string text3 = text2.Split(array3)[1];
					char[] array4 = new char[1];
					array4[1] = 'ﾎ';
					string text4 = text2.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text4))
					{
						text3 = string.Empty + BMAEINMDAFF;
					}
					string text5 = text;
					string[] array5 = new string[2];
					array5[1] = text5;
					array5[0] = ((text.Length <= 1) ? string.Empty : "[ItemsHandler] Inventory not changed");
					array5[6] = text3;
					array5[2] = "SetEnvSpriteColor";
					array5[8] = text4;
					text = string.Concat(array5);
				}
				votes = text;
			}
			else
			{
				object[] array6 = new object[3];
				array6[0] = MIDAMGAGFIA();
				array6[0] = "2hands";
				array6[3] = BMAEINMDAFF;
				array6[2] = "_Value2";
				array6[1] = SteamUser.GetSteamID().m_SteamID;
				AIAJMCKBLKI(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(IHGAFOAMKAD(), BMAEINMDAFF);
		}

		[SpecialName]
		public ulong KIHKKAFMDMF()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void POPAHCMKOHP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LKGIPBNFPEL()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		public int KHMMMHMDFNF()
		{
			int result = 0;
			try
			{
				string text = MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = '\u0002';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[1];
					array4[1] = '\u0016';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						char[] array5 = new char[0];
						array5[0] = 'ﾪ';
						result = int.Parse(text2.Split(array5)[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public void OKJFBOFMGMO(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJFBKKPFFMI(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFNAMIGJCLM(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFGKIMOAGJD(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		public int EPHHAGCNLNF()
		{
			int num = 0;
			try
			{
				string text = MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = 'E';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					int num2 = num;
					char[] array4 = new char[0];
					array4[0] = 'ﾔ';
					num = num2 + int.Parse(text2.Split(array4)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		public int CMIDMJKBAGJ()
		{
			int result = 0;
			try
			{
				string[] array = FJICLFAAFNM().Split('0');
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string text = array2[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array3 = new char[1];
					array3[1] = 'N';
					if (num == ulong.Parse(text.Split(array3)[0]))
					{
						char[] array4 = new char[0];
						array4[1] = '\uffd1';
						result = int.Parse(text.Split(array4)[1]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		[SpecialName]
		public string HOHOAOGHFDO()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public void NGAPNJIANCP(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		public void JGIJADECLGB(int BMAEINMDAFF)
		{
			if (IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string text2 = FJICLFAAFNM();
				char[] array = new char[0];
				array[1] = 'ﾖ';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[1] = 'ﾶ';
					string text4 = text3.Split(array4)[0];
					char[] array5 = new char[0];
					array5[1] = '3';
					string text5 = text3.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[0];
					array6[1] = text6;
					array6[0] = ((text.Length <= 0) ? string.Empty : "ViewID {0} {1}{2}");
					array6[6] = text4;
					array6[5] = "_Value";
					array6[0] = text5;
					text = string.Concat(array6);
				}
				MHKPAIMLJHH(text);
			}
			else
			{
				object[] array7 = new object[0];
				array7[1] = BFIJMABPKOF();
				array7[0] = "BitsData";
				array7[4] = BMAEINMDAFF;
				array7[7] = "_TimeX";
				array7[8] = SteamUser.GetSteamID().m_SteamID;
				PDGNODHEFOF(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(PHCHLPBPKHL(), BMAEINMDAFF);
		}

		[SpecialName]
		public ulong LPEKOHPMKCE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong PHCHLPBPKHL()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong DBCMHPJIHGG()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string MOMHHCGBDJK()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string CKGFBNMMPMC()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void EJDKCELGOFG(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LJMEJHIHPGI(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LJELNGLNFHM(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string POJIOBLCHPI()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void OGHFEGGAGBK(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong DFKBFAHDLJE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public int IPLNCBFBGFJ()
		{
			int result = 0;
			try
			{
				string text = FHMMOHLGLOL();
				char[] array = new char[1];
				array[1] = 'ﾳ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[1] = 'ﾦ';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						result = int.Parse(text2.Split('\b')[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		public void SetUserVote(int BMAEINMDAFF)
		{
			if (GetUserVote() != 0)
			{
				string text = string.Empty;
				string[] array = votes.Split(';');
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					string text3 = text2.Split('|')[0];
					string text4 = text2.Split('|')[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text4))
					{
						text3 = string.Empty + BMAEINMDAFF;
					}
					string text5 = text;
					text = text5 + ((text.Length <= 0) ? string.Empty : ";") + text3 + "|" + text4;
				}
				votes = text;
			}
			else
			{
				votes = votes + ";" + BMAEINMDAFF + "|" + SteamUser.GetSteamID().m_SteamID;
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(id, BMAEINMDAFF);
		}

		public int KBIEDPCEHGG()
		{
			int num = 1;
			try
			{
				string[] array = NJKPMJKDOMK().Split('ﾋ');
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string text = array2[i];
					int num2 = num;
					char[] array3 = new char[1];
					array3[1] = 'ￔ';
					num = num2 + int.Parse(text.Split(array3)[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string CNIIOBIAONN()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}
	}

	public class PlayerServerData
	{
		public string bgURL { get; set; }

		public List<Challenge> activeChallenges { get; set; }

		[SpecialName]
		public void EOBMHGEIEBA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string AIGEAHLELBA()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void IFFBIJPAAHN(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> BGLCJNOBNKD()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void MAEIHICNGIN(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HANHDJIECKM()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> ENBDNHKPBNP()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string POJMJIJJHEO()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void CHIKIOKECNH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string AJKNCCPNEDL()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void KKGHHLLHPPN(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> BILBPKBMBBI()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void EAJKLIPKJLE(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> ONBAJFKPBEN()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void PMNOIBHECAE(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NLOBGCLIMED()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void IFHOCAJGECA(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> CAFNLIMAJMD()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void DIDELGKFHGB(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string PKJCIMBJODL()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void IFCMOCAIGFH(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HIHBNECEAHC(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JMGAMCAIDDG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBBAOAAHICE(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PIJOAIEPJPI(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DHOFLGHAAIH(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> BKFELAKDMKF()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void CPNCEPBJLLF(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MFALGEOCLED(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IJMHCOHAOFF(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class ServerDataJson
	{
		public FastRanksJson playerRanksTable { get; set; }

		public TeamJson teamTable { get; set; }

		public BanListJson banList { get; set; }

		public MapsListJson mapsList { get; set; }

		public PlayersTipsJson playersTips { get; set; }

		public PlayerServerData playerServerData { get; set; }

		[SpecialName]
		public BanListJson MOCAJHGFOEH()
		{
			return _003CFGIOJMFIIBO_003Ek__BackingField;
		}

		[SpecialName]
		public void KPOODIINKII(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OIEFGAIDCPD(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public MapsListJson EBKEHMMONMH()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public MapsListJson DGIEFGKLFLD()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public MapsListJson LOHMDECDBNF()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public void OKGKMFOGIJO(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CEIEIHDIFJL(TeamJson DPNHODJHGJL)
		{
			_003CMHLNPPIHHAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FCDKNMBOHFP(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public TeamJson DKHPAENCMFH()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson LCIEOKPKPKH()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void HCCCCBALHNG(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public TeamJson FLPBOBHLFEN()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void CINOJOMNAPN(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LDADCMFPINM(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData MPMAENGEPOJ()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public MapsListJson FEJJMBCIENK()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public PlayersTipsJson ECGLNCJGAID()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public void INOBAGADIPK(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LKMIECNCHCC(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData HECDOOJEOJI()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson BHDJOLPNCNK()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson EAIDOBONKFP()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void IPPKGHJGJKN(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MLFKAMAFGPP(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DNELOPFFEMF(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DKCPAIOBEDP(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NHJCKPGKPOM(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public MapsListJson HMDKBJCAINK()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public PlayerServerData BLAFJKNGHDE()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void KMHKIBNDJOH(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FCCKGHCDELE(TeamJson DPNHODJHGJL)
		{
			_003CMHLNPPIHHAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayersTipsJson JMMCIIMNCIN()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public void HHHIKAJLGJF(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BFGIJGLPIOA(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public TeamJson JGPFNEGDBDH()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void HPPPFGHGBAO(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public BanListJson ODCMAFLNADL()
		{
			return _003CFGIOJMFIIBO_003Ek__BackingField;
		}

		[SpecialName]
		public PlayerServerData HMBMHBFIEBE()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void DFKHDPGCEFD(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public BanListJson KPBNNABNFHA()
		{
			return _003CFGIOJMFIIBO_003Ek__BackingField;
		}

		[SpecialName]
		public void NINBMGBLMLF(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EAEHADJOEMH(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayersTipsJson EDOGFAPCLPM()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson MEJAOJLMNKF()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public PlayerServerData PDHLBLFODON()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void ONNIFJAMAFG(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DNOPHHLMFDA(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PKLIDLIKAOB(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DHHFKDAPGAB(TeamJson DPNHODJHGJL)
		{
			_003CMHLNPPIHHAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HBDHGMPAOJL(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMHNKEMBIBK(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData OPGANDHGOCM()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void CEDEKCDGKEB(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LLALBGGOFNK(TeamJson DPNHODJHGJL)
		{
			_003CMHLNPPIHHAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEGFFOMJGNA(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public MapsListJson EIBJDBDPOJC()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public void GBIPCEHCLFG(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData KEKBOMFPMBA()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void KEKIEKPPMHJ(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData ADNDGOJPIGC()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void EONKPHPOKFL(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public TeamJson JOBJNLEPHBE()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void IHDIGEDPPBP(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayerServerData KIHIEKLEMMI()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public PlayersTipsJson ELDLJMBHGAN()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson HNENIDFABLJ()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public BanListJson MBMELLBNGOE()
		{
			return _003CFGIOJMFIIBO_003Ek__BackingField;
		}

		[SpecialName]
		public BanListJson DDCHAKMKDEP()
		{
			return _003CFGIOJMFIIBO_003Ek__BackingField;
		}

		[SpecialName]
		public MapsListJson IPKHDLGKPPM()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public void BCIGCHHFJNO(TeamJson DPNHODJHGJL)
		{
			_003CMHLNPPIHHAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FAOHJAAIJKH(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	[CompilerGenerated]
	private sealed class EGNLMILBMMC
	{
		internal ulong JMMILEFMACB;

		internal bool CPGJCCBMBBF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BJMAIJDIKCN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool IFHICADFDCE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool AHBIANHNBBC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EAPKJLONHBG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool MACILKHEBEF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool HNOIFOOJMCC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool MMKHFOFJKNI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool JBIMMGGGMPB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool EKHOOPGPPGE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool BCDAGGDDADL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool LDNDNOOCFFA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool KMIAINALJFJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool LHONOMOAHJD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HCFLGKJFKFE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool AGJKEBOPIOC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool PLEFJLBGDOJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool JDELIMPGFDJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool BHMNMHFDPLN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool PKJCCIGEACE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool MPGGBMMPNDH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool PHDFIAGENEE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GBFDHKGDDPO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JBAJEMGOPDL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool BOPKCHEPEEB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool FHAMDNDPKBA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool CBKBFHDKJEE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool HGOHMNAGGKI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GNPPNNLJLMP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool AEIFJLBBKBP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool IACBEPMAJPH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool FLKOOOGMBFJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool AHHNAGGBKOO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool PHJAIEAAMPH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HEPDDMCNEKD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool DMFFNNFKEAA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool ONEPCCGOEKI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool LLPCCJGMEIE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool INHOEMCLAAP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool PHGILLBNBME(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool LNHHFDKFLAA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HMMBBDJNGGL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KFNBKFELFLH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool MFBMMDCIPGG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool PODLCOEIIGA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool GBIHGLCGNCM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool BMAOCLKPNNC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool IIFJOGHFCGK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DMKALNCPIAJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool LMNCLJKEIFD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OJFHDDECJKC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool HBJOAAJMDDE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool JJPOFCGCKJF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool BOJCHGIGGNK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool FIPCLHEKKCA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool BLGDLGLNCHE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool CMBLCKNFNIF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OAKGNJNMBFK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool EDNIIDHFIJH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool DPFLLMAOIHH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool PDNFNOLBNIF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool CDJJGFHFMBL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PCDFLCEIHFF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OPNIKCBNOIF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool MBOCPCMMJDI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool NEIDGMKKCBI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BAKPHDMIHFE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool OHMLDGGHGIL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool EFAPFFFGOOA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool LCAIGLPKJAF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool PMEFBOOIAKK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PMPBFHNELAJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool INFIHILKMBK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool MJBBOHLIILO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool FPONLDMBLPK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool CEFNPJBKLDM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool IJINAAGMHKM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool EEBODGOFEGB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool LBNMAMJDFLG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool BLEKGEPJBFN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool HDJPOBPGKAK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool ILADLNPPGAO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool PLINPGHDODA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BEFJFFLBLCE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool BJCNLIJFEKF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool LKFKDAEBCPN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool MJCLCLJEOIF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool DAJMIEHCEMJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool KFGCBAHGDNK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool KGKMOLCPDIH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool KKCGGMGGFLC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool DOBBJPPAEBB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool CANILAHOIGL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool LKLABDAJAEH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool GCLCICMFCPK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool CCLAJACDMHG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool NCGABJOKHGO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool INALCBKJMHI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool AAPNNKGJEOG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool GEPBCIIDMBC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool NHPDJEKEOKI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool ILCENHENOKK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool EIJKHJOCCAE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EIKNHEAEHJC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool CCJEFHIHEID(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool MPOCBBDLGMP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool NDGKBJEKAPJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LADECCOJPPL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool KFNPHCCAJFD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool AGFDCBCBAGI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool NFMMONDLJCC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool PGJLKLKAADB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool DBHMMIKIBIO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == JMMILEFMACB;
		}

		internal bool BPJGFELFEDC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool DFPLMEODJAM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool JPICHJKIMDH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool LJDLIIIPIIJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool DNIMHEKGJHB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool DGFFNMKBANM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool HAHHLEACNIL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EBEGBCEJBFI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PMKGJLKNBJB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool OLIGLEMPFOP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool BFEABMIFIEE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool MOJCLHBKMHF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == JMMILEFMACB;
		}

		internal bool OODLIEKJILO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool ACLHMMEEIDA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == JMMILEFMACB;
		}

		internal bool MJBOKIODLFF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}

		internal bool BDGDIDPDBHG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool DBOEBFFAOFJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == JMMILEFMACB;
		}

		internal bool PIJAOCFAPKC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == JMMILEFMACB;
		}

		internal bool JGEDLMKBGGL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == JMMILEFMACB;
		}
	}

	[CompilerGenerated]
	private sealed class OFIPPJELEIA
	{
		internal CSteamID GDOHPDHLPBC;

		internal bool DKGPCPBNDPK(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BFEABMIFIEE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LNDGINDKPFA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BKNHHGBPLGH(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EGKGJJGAPMN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BDGDIDPDBHG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool PBCAHKDLFPE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FIPCLHEKKCA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool GBKBDKHPLKG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JDELIMPGFDJ(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OFHCGKJFGDI(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EKHOOPGPPGE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LHHFJBIAHCN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool KFNBKFELFLH(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OLIGLEMPFOP(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool DBFPGFHEGKA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JKEDCEOCPJO(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LLNDDFGPOPL(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool MEMPOPNAEDN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FFEGPHJKMFK(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LOEAMHGMMPK(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AEINPAGJFME(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}
	}

	public string serverDataUrl = "?";

	public string ranksUrl = "?";

	public string leaderboardUrl = "?";

	public string submitScoreUrl = "?";

	public string updateMapMD5Url = "?";

	public string serverStatusUrl = "?";

	[SerializeField]
	private string s = "?";

	[SerializeField]
	private string t = "?";

	[HideInInspector]
	public string bgURL = string.Empty;

	private List<Ban> FNNKEJFCOPO = new List<Ban>();

	private List<Map> AHJIKFNJJNA = new List<Map>();

	private List<PlayerTip> HEECFLEMGOP = new List<PlayerTip>();

	private Dictionary<CSteamID, PlayersRank> PJCIDKMPHDD = new Dictionary<CSteamID, PlayersRank>();

	[HideInInspector]
	public bool isLoaded;

	public float ranksUpdateTimeoutSeconds = 300f;

	private DateTime AHIIEMAHBFE = DateTime.Now;

	private int CJDDPDGBLNM;

	public bool isRankChanged;

	public GameObject rankUpdateCanvas;

	public Text messageText;

	public Text rankText;

	private bool GPNKIEPLHNJ;

	public static List<PlayerTip> HACOOAAIPEN()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	private IEnumerator HABBEOOPKJI()
	{
		GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			yield break;
		}
		CJDDPDGBLNM = 0;
		int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1);
		if (@int == -1)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
			rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID());
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
			GPNKIEPLHNJ = false;
			yield return new WaitForSeconds(5f);
			CloseRanksChanges();
			yield break;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).place - @int;
		if (CJDDPDGBLNM < 0)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
		}
		else
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
		}
		string loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
		int num = @int;
		int place = GetLoadedRank(SteamUser.GetSteamID()).place;
		string text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
		rankText.text = text;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
		yield return new WaitForSeconds(0.25f);
		int num2 = 1;
		while (num != place)
		{
			num += ((CJDDPDGBLNM >= 0) ? num2 : (-num2));
			text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
			rankText.text = text;
			float num3 = Mathf.Abs(num - GetLoadedRank(SteamUser.GetSteamID()).place);
			float seconds = 0f;
			num2 = Mathf.RoundToInt(num3 / 10f);
			if (num2 < 1)
			{
				num2 = 1;
			}
			if (num3 <= 1000f)
			{
				seconds = 0.001f;
			}
			if (num3 <= 100f)
			{
				seconds = 0.005f;
			}
			if (num3 <= 50f)
			{
				seconds = 0.01f;
			}
			if (num3 <= 20f)
			{
				seconds = 0.02f;
			}
			if (num3 <= 10f)
			{
				seconds = 0.03f;
			}
			if (num3 <= 5f)
			{
				seconds = 0.05f;
			}
			if (num3 <= 2f)
			{
				num2 = 1;
				seconds = 0.1f;
			}
			if (num3 <= 1f)
			{
				num2 = 1;
				seconds = 0.2f;
			}
			if (GPNKIEPLHNJ)
			{
				yield return new WaitForSeconds(seconds);
			}
		}
		GPNKIEPLHNJ = false;
		yield return new WaitForSeconds(5f);
		CloseRanksChanges();
	}

	public void ViewAllRanks()
	{
		CloseRanksChanges();
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer());
	}

	public void DAHGNLKGIJK()
	{
		StartCoroutine(IBFLEPDMPKJ());
	}

	public static Color GetRankShadowColor(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "#000000CC";
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= 500)
			{
			}
			if (JMICLAEOFNP <= 100)
			{
			}
			if (JMICLAEOFNP <= 25)
			{
			}
			if (JMICLAEOFNP <= 10)
			{
				mLPCOMHPPNH = "#FFDA44CC";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public void PMHFJKDEOMG()
	{
		if (GameManager.BGDFGGHAHHD() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("???", 0) == 1)
		{
			StartCoroutine(BLJMABEIKGD());
		}
		isRankChanged = false;
	}

	public static void SetLoadedRank(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].place = JMICLAEOFNP;
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	private IEnumerator IBFLEPDMPKJ(bool HOCAOEIDOEL = false)
	{
		yield return new WaitUntil(() => LocalizationService.Instance.inited);
		if (GameManager.IsOffline)
		{
			isLoaded = true;
			FNNKEJFCOPO = new List<Ban>();
			AHJIKFNJJNA = new List<Map>();
			HEECFLEMGOP = new List<PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
		}
		else if (HOCAOEIDOEL || AHIIEMAHBFE < DateTime.Now)
		{
			string url = Singleton<GameManager>.Instance.CreateServerURL(serverStatusUrl);
			WWW wWW = new WWW(url);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Connection error: " + wWW.error, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			ServerResponse serverResponse = JsonConvert.DeserializeObject<ServerResponse>(wWW.text);
			if (serverResponse.status == 1)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null);
			}
			if (serverResponse.status == 2)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(serverResponse.statusMessage, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			int num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
			if (num < 0)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Outdated version. Please restart the game to get lastest updates.", "#later", delegate
				{
				}, "#restart", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
			}
			WWW wWW2 = new WWW(string.Concat(str1: SteamUser.GetSteamID().m_SteamID.ToString(), str0: Singleton<GameManager>.Instance.CreateServerURL(serverDataUrl)));
			yield return wWW2;
			if (!string.IsNullOrEmpty(wWW2.error))
			{
				Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW2.error);
			}
			ServerDataJson serverDataJson = JsonConvert.DeserializeObject<ServerDataJson>(wWW2.text);
			foreach (FastPlayersRank playersRank in serverDataJson.playerRanksTable.playersRanks)
			{
				try
				{
					SetLoadedRank((CSteamID)ulong.Parse(playersRank.s), playersRank.p);
				}
				catch (Exception)
				{
				}
			}
			TeamJson teamTable = serverDataJson.teamTable;
			foreach (ulong dev in teamTable.devs)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)dev))
				{
					PJCIDKMPHDD[(CSteamID)dev].isDev = true;
				}
			}
			foreach (ulong moderator in teamTable.moderators)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)moderator))
				{
					PJCIDKMPHDD[(CSteamID)moderator].isModerator = true;
				}
			}
			foreach (ulong item in teamTable.team)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)item))
				{
					PJCIDKMPHDD[(CSteamID)item].isTeam = true;
				}
			}
			BanListJson banList = serverDataJson.banList;
			FNNKEJFCOPO.Clear();
			foreach (Ban ban in banList.bans)
			{
				FNNKEJFCOPO.Add(ban);
			}
			MapsListJson mapsList = serverDataJson.mapsList;
			AHJIKFNJJNA.Clear();
			foreach (Map map in mapsList.maps)
			{
				AHJIKFNJJNA.Add(map);
			}
			PlayersTipsJson playersTips = serverDataJson.playersTips;
			HEECFLEMGOP.Clear();
			foreach (PlayerTip tip in playersTips.tips)
			{
				HEECFLEMGOP.Add(tip);
			}
			PlayerServerData playerServerData = serverDataJson.playerServerData;
			bgURL = playerServerData.bgURL;
			Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
			AHIIEMAHBFE = DateTime.Now.AddSeconds(ranksUpdateTimeoutSeconds);
			Debug.Log("[RanksSystem] Ranks updated. Next update: " + AHIIEMAHBFE);
			isLoaded = true;
			KAOIOJBHFOD();
			yield return StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
	}

	public void Init()
	{
		isLoaded = false;
		Debug.Log("[RanksSystem] Init");
		ReloadServerInfo();
	}

	public void KFBKMKHMAPJ()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("[Singleton] An instance of '", 1) == 0)
		{
			StartCoroutine(CJELLDGCDEO());
		}
		isRankChanged = false;
	}

	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("subscribeall", MIONODPCAFD, "Run a command for data system", "<command>");
	}

	public string GetS()
	{
		return s;
	}

	private void KAOIOJBHFOD()
	{
		isRankChanged = false;
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			return;
		}
		CJDDPDGBLNM = 0;
		int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1);
		if (@int == -1)
		{
			isRankChanged = true;
			return;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).place - @int;
		if (CJDDPDGBLNM != 0)
		{
			isRankChanged = true;
		}
	}

	public static Color KBIACFGMDNG(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "_ScreenResolution";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = " (inactive)";
		}
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= -61)
			{
				mLPCOMHPPNH = "_Value";
			}
			if (JMICLAEOFNP <= -50)
			{
				mLPCOMHPPNH = "_Extra2";
			}
			if (JMICLAEOFNP <= -14)
			{
				mLPCOMHPPNH = "_OcclusionTexture";
			}
			if (JMICLAEOFNP <= 3)
			{
				mLPCOMHPPNH = "_ScreenResolution";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	private IEnumerator BLJMABEIKGD()
	{
		GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			yield break;
		}
		CJDDPDGBLNM = 0;
		int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1);
		if (@int == -1)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
			rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID());
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
			GPNKIEPLHNJ = false;
			yield return new WaitForSeconds(5f);
			CloseRanksChanges();
			yield break;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).place - @int;
		if (CJDDPDGBLNM < 0)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
		}
		else
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
		}
		string loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
		int num = @int;
		int place = GetLoadedRank(SteamUser.GetSteamID()).place;
		string text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
		rankText.text = text;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
		yield return new WaitForSeconds(0.25f);
		int num2 = 1;
		while (num != place)
		{
			num += ((CJDDPDGBLNM >= 0) ? num2 : (-num2));
			text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
			rankText.text = text;
			float num3 = Mathf.Abs(num - GetLoadedRank(SteamUser.GetSteamID()).place);
			float seconds = 0f;
			num2 = Mathf.RoundToInt(num3 / 10f);
			if (num2 < 1)
			{
				num2 = 1;
			}
			if (num3 <= 1000f)
			{
				seconds = 0.001f;
			}
			if (num3 <= 100f)
			{
				seconds = 0.005f;
			}
			if (num3 <= 50f)
			{
				seconds = 0.01f;
			}
			if (num3 <= 20f)
			{
				seconds = 0.02f;
			}
			if (num3 <= 10f)
			{
				seconds = 0.03f;
			}
			if (num3 <= 5f)
			{
				seconds = 0.05f;
			}
			if (num3 <= 2f)
			{
				num2 = 1;
				seconds = 0.1f;
			}
			if (num3 <= 1f)
			{
				num2 = 1;
				seconds = 0.2f;
			}
			if (GPNKIEPLHNJ)
			{
				yield return new WaitForSeconds(seconds);
			}
		}
		GPNKIEPLHNJ = false;
		yield return new WaitForSeconds(5f);
		CloseRanksChanges();
	}

	public void FIBAFHIJCBM()
	{
		if (GameManager.BGDFGGHAHHD() && Singleton<SaveSystem>.Instance.JPEEFKKPFIL("[EMPTY]", 0) == 1)
		{
			StartCoroutine(BLJMABEIKGD());
		}
		isRankChanged = false;
	}

	private void JHDDEDHIHLO(string[] BDGDDFKKGGA)
	{
		foreach (Map item in FIENAHLCHIF())
		{
			Debug.Log("MenuRecordButton" + item.GOMJAEIDHNM());
			Singleton<MapsSystem>.Instance.MMLOJFEBOHN(new PublishedFileId_t(item.id));
		}
	}

	private void GDCEDAFBJKI(string[] BDGDDFKKGGA)
	{
		foreach (Map officialMaps in GetOfficialMapsList())
		{
			Debug.Log("Value" + officialMaps.GOMJAEIDHNM());
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(officialMaps.GOMJAEIDHNM()));
		}
	}

	public static void LLOMEHCONNJ(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("SearchTex" + JMMILEFMACB);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "CameraFilterPack_Atmosphere_Rain_FX" + Helpers.levelConfigFileName;
			Debug.Log("_TimeX" + JMMILEFMACB);
			Debug.Log("..." + Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper());
			Debug.Log("_ScreenResolution" + Math.Round(Helpers.GetMapDifficulty(mapData.mapData), 2).ToString().Replace('3', '{'));
			Debug.Log("/" + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("_Near" + Math.Round(mapData.mapData.musicTime, 8).ToString().Replace('ﾀ', '\ufffe'));
		}
	}

	public IEnumerator HKGMJFOIAMJ(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("difficulty", string.Empty + NINLCJIFACI);
		wWWForm.AddField("maxScore", string.Empty + JEHNGECOPJN);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(updateMapMD5Url);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.error, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
		else if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
	}

	public void OCHADIJNDJK()
	{
		isLoaded = true;
		Debug.Log("CameraFilterPack/Drawing_Toon");
		DAHGNLKGIJK();
	}

	public static Color GetRankColor(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "#FFFFFF";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = "#000000";
		}
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= 500)
			{
				mLPCOMHPPNH = "#91CCFF";
			}
			if (JMICLAEOFNP <= 100)
			{
				mLPCOMHPPNH = "#EA4137";
			}
			if (JMICLAEOFNP <= 25)
			{
				mLPCOMHPPNH = "#E14FFF";
			}
			if (JMICLAEOFNP <= 10)
			{
				mLPCOMHPPNH = "#FFDA44";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public static List<PlayerTip> JJEHNLHAAGC()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	private void MIONODPCAFD(string[] BDGDDFKKGGA)
	{
		foreach (Map officialMaps in GetOfficialMapsList())
		{
			Debug.Log("Subscribe: " + officialMaps.id);
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(officialMaps.id));
		}
	}

	private void NCHNFKLMMCO(string[] BDGDDFKKGGA)
	{
		foreach (Map item in HOCEONHMGHM())
		{
			Debug.Log(" " + item.HJPGIGBFCID());
			Singleton<MapsSystem>.Instance.MMLOJFEBOHN(new PublishedFileId_t(item.CHDCIFPPIFI()));
		}
	}

	public void CloseRanksChanges()
	{
		if (!GPNKIEPLHNJ)
		{
			StopCoroutine(HABBEOOPKJI());
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, false));
			Singleton<SaveSystem>.Instance.SetInt("player.currentrank", GetLoadedRank(SteamUser.GetSteamID()).place);
		}
		else
		{
			GPNKIEPLHNJ = false;
		}
	}

	public static List<Map> FIENAHLCHIF()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	public void GEFOBOIAJHI()
	{
		if (GameManager.ACMHININJEL() && Singleton<SaveSystem>.Instance.GetInt("bans.viewed.", 1) == 1)
		{
			StartCoroutine(HABBEOOPKJI());
		}
		isRankChanged = true;
	}

	public static PlayersRank GetLoadedRank(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<RanksSystem>.Instance.PJCIDKMPHDD[HFEFHOPOLIK];
		}
		return null;
	}

	public static List<Ban> GOICCEIEJAI(CSteamID GDOHPDHLPBC)
	{
		return Singleton<RanksSystem>.Instance.FNNKEJFCOPO.FindAll((Ban IACGDFHKCAE) => IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC);
	}

	public static Dictionary<CSteamID, PlayersRank> GetRanksList()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	public static Color KLOEHDOKBBO(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "_TimeX";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = "_Value4";
		}
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 133)
			{
				mLPCOMHPPNH = "Remove Environment Object";
			}
			if (JMICLAEOFNP <= 57)
			{
				mLPCOMHPPNH = "CameraFilterPack/3D_Anomaly";
			}
			if (JMICLAEOFNP <= 46)
			{
				mLPCOMHPPNH = "_TimeX";
			}
			if (JMICLAEOFNP <= -86)
			{
				mLPCOMHPPNH = "[MapEditor] Loading music...";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public static Color DIAJLJLONAC(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "settings.hideui";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 187)
			{
			}
			if (JMICLAEOFNP <= 3)
			{
			}
			if (JMICLAEOFNP <= -74)
			{
			}
			if (JMICLAEOFNP <= 36)
			{
				mLPCOMHPPNH = "B";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public static List<Ban> GetCurrentPlayerBans(CSteamID GDOHPDHLPBC)
	{
		return Singleton<RanksSystem>.Instance.FNNKEJFCOPO.FindAll((Ban IACGDFHKCAE) => IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC);
	}

	public void NKLCNJEIAFB()
	{
		isLoaded = true;
		Debug.Log("_BlurPass");
		ReloadServerInfo();
	}

	public long LOLDPLJIOPH(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-56, 1, 0, 1, 1, 1)).TotalSeconds;
	}

	public IEnumerator CKGBLPLHJFG(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("difficulty", string.Empty + NINLCJIFACI);
		wWWForm.AddField("maxScore", string.Empty + JEHNGECOPJN);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(updateMapMD5Url);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.error, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
		else if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
	}

	public static void OOCPADIDCEM(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].OCBEDPHDKMN(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	private IEnumerator KBBCCGACIFJ(bool HOCAOEIDOEL = false)
	{
		yield return new WaitUntil(() => LocalizationService.Instance.inited);
		if (GameManager.IsOffline)
		{
			isLoaded = true;
			FNNKEJFCOPO = new List<Ban>();
			AHJIKFNJJNA = new List<Map>();
			HEECFLEMGOP = new List<PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
		}
		else if (HOCAOEIDOEL || AHIIEMAHBFE < DateTime.Now)
		{
			string url = Singleton<GameManager>.Instance.CreateServerURL(serverStatusUrl);
			WWW wWW = new WWW(url);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Connection error: " + wWW.error, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			ServerResponse serverResponse = JsonConvert.DeserializeObject<ServerResponse>(wWW.text);
			if (serverResponse.status == 1)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null);
			}
			if (serverResponse.status == 2)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(serverResponse.statusMessage, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			int num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
			if (num < 0)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Outdated version. Please restart the game to get lastest updates.", "#later", delegate
				{
				}, "#restart", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
			}
			WWW wWW2 = new WWW(string.Concat(str1: SteamUser.GetSteamID().m_SteamID.ToString(), str0: Singleton<GameManager>.Instance.CreateServerURL(serverDataUrl)));
			yield return wWW2;
			if (!string.IsNullOrEmpty(wWW2.error))
			{
				Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW2.error);
			}
			ServerDataJson serverDataJson = JsonConvert.DeserializeObject<ServerDataJson>(wWW2.text);
			foreach (FastPlayersRank playersRank in serverDataJson.playerRanksTable.playersRanks)
			{
				try
				{
					SetLoadedRank((CSteamID)ulong.Parse(playersRank.s), playersRank.p);
				}
				catch (Exception)
				{
				}
			}
			TeamJson teamTable = serverDataJson.teamTable;
			foreach (ulong dev in teamTable.devs)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)dev))
				{
					PJCIDKMPHDD[(CSteamID)dev].isDev = true;
				}
			}
			foreach (ulong moderator in teamTable.moderators)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)moderator))
				{
					PJCIDKMPHDD[(CSteamID)moderator].isModerator = true;
				}
			}
			foreach (ulong item in teamTable.team)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)item))
				{
					PJCIDKMPHDD[(CSteamID)item].isTeam = true;
				}
			}
			BanListJson banList = serverDataJson.banList;
			FNNKEJFCOPO.Clear();
			foreach (Ban ban in banList.bans)
			{
				FNNKEJFCOPO.Add(ban);
			}
			MapsListJson mapsList = serverDataJson.mapsList;
			AHJIKFNJJNA.Clear();
			foreach (Map map in mapsList.maps)
			{
				AHJIKFNJJNA.Add(map);
			}
			PlayersTipsJson playersTips = serverDataJson.playersTips;
			HEECFLEMGOP.Clear();
			foreach (PlayerTip tip in playersTips.tips)
			{
				HEECFLEMGOP.Add(tip);
			}
			PlayerServerData playerServerData = serverDataJson.playerServerData;
			bgURL = playerServerData.bgURL;
			Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
			AHIIEMAHBFE = DateTime.Now.AddSeconds(ranksUpdateTimeoutSeconds);
			Debug.Log("[RanksSystem] Ranks updated. Next update: " + AHIIEMAHBFE);
			isLoaded = true;
			KAOIOJBHFOD();
			yield return StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
	}

	public string LHCBFIBKHLA()
	{
		return s;
	}

	public IEnumerator ABLBIOGGGKC(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("difficulty", string.Empty + NINLCJIFACI);
		wWWForm.AddField("maxScore", string.Empty + JEHNGECOPJN);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(updateMapMD5Url);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.error, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
		else if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
	}

	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	public static bool IsOfficial(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		if (Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Exists((Map IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB))
		{
			if (!LFCLCNMPCNM)
			{
				return true;
			}
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("workshop." + JMMILEFMACB);
			if (mapData != null)
			{
				string dDAOMDPAIEP = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
				if (!string.IsNullOrEmpty(Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB).hash))
				{
					return Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper() == Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB).hash.ToUpper();
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public void DisplayRanksChanges()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("settings.enablerankingnotifications", 1) == 1)
		{
			StartCoroutine(HABBEOOPKJI());
		}
		isRankChanged = false;
	}

	public IEnumerator SubmitScore(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("gamemode", string.Empty + (int)MHGOFBOPNLG);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("score", string.Empty + EPLJLGAIJCM);
		wWWForm.AddField("accuracy", string.Empty + LODDNOOJFPA);
		wWWForm.AddField("misses", string.Empty + FNPFEOPCHHJ);
		wWWForm.AddField("replayData", string.Empty + FBDLGEIDEDA);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + s + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
	}

	public static List<Map> HOCEONHMGHM()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	public static List<Map> GetOfficialMapsList()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	public IEnumerator DJHAGBKILNI(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("gamemode", string.Empty + (int)MHGOFBOPNLG);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("score", string.Empty + EPLJLGAIJCM);
		wWWForm.AddField("accuracy", string.Empty + LODDNOOJFPA);
		wWWForm.AddField("misses", string.Empty + FNPFEOPCHHJ);
		wWWForm.AddField("replayData", string.Empty + FBDLGEIDEDA);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + s + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
	}

	public static void PrintStats(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("workshop." + JMMILEFMACB);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			Debug.Log("[MapsStats] Map ID: " + JMMILEFMACB);
			Debug.Log("[MapsStats] Hash: " + Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper());
			Debug.Log("[MapsStats] Difficulty: " + Math.Round(Helpers.GetMapDifficulty(mapData.mapData), 2).ToString().Replace(',', '.'));
			Debug.Log("[MapsStats] Max score: " + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("[MapsStats] Length: " + Math.Round(mapData.mapData.musicTime, 2).ToString().Replace(',', '.'));
		}
	}

	public IEnumerator UpdateOfficialMap(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("difficulty", string.Empty + NINLCJIFACI);
		wWWForm.AddField("maxScore", string.Empty + JEHNGECOPJN);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(updateMapMD5Url);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.error, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
		else if (!wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#md5submitionfailed: " + wWW.text, "#tryagain", delegate
			{
				StartCoroutine(UpdateOfficialMap(CBOLFPGKALK, JKGOFJKFDED, NINLCJIFACI, JEHNGECOPJN));
			}, "#close", delegate
			{
			}));
		}
	}

	private void DFCILMAJFIC()
	{
		isRankChanged = true;
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			return;
		}
		CJDDPDGBLNM = 1;
		int num = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_Near", -1);
		if (num == -1)
		{
			isRankChanged = false;
			return;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).IEOGJOLGLFI() - num;
		if (CJDDPDGBLNM != 0)
		{
			isRankChanged = true;
		}
	}

	public static void KNMHMBBCNJK(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("visible" + JMMILEFMACB);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "Hello" + Helpers.levelConfigFileName;
			Debug.Log("inventory.selected." + JMMILEFMACB);
			Debug.Log("OxOD.lastPath" + Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper());
			Debug.Log("_TimeX" + Math.Round(Helpers.GetMapDifficulty(mapData.mapData), 5).ToString().Replace('r', ':'));
			Debug.Log(" " + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("action" + Math.Round(mapData.mapData.musicTime, 3).ToString().Replace('￮', 'ﾈ'));
		}
	}

	public long NHBOHPPIALG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(129, 1, 1, 0, 1, 1)).TotalSeconds;
	}

	public void ReloadServerInfo(bool HOCAOEIDOEL)
	{
		StartCoroutine(PEPBPLCDPEH(HOCAOEIDOEL));
	}

	public void ILMJPBGLAGI(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		object[] array = new object[6];
		array[0] = "settings.fps";
		array[0] = KKPILMGBPMD;
		array[4] = "SupportLogger OnFailedToConnectToPhoton(";
		array[4] = BMAEINMDAFF;
		Debug.Log(string.Concat(array));
	}

	public void FPPFNPMJECN()
	{
		CloseRanksChanges();
		StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1));
	}

	public void SubmitUserVote(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		Debug.Log("SubmitUserVote:" + KKPILMGBPMD + " - " + BMAEINMDAFF);
	}

	public IEnumerator HPJEBNGAHNA(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("gamemode", string.Empty + (int)MHGOFBOPNLG);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("score", string.Empty + EPLJLGAIJCM);
		wWWForm.AddField("accuracy", string.Empty + LODDNOOJFPA);
		wWWForm.AddField("misses", string.Empty + FNPFEOPCHHJ);
		wWWForm.AddField("replayData", string.Empty + FBDLGEIDEDA);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + s + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator JAHLDECAKGK(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("gamemode", string.Empty + (int)MHGOFBOPNLG);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("score", string.Empty + EPLJLGAIJCM);
		wWWForm.AddField("accuracy", string.Empty + LODDNOOJFPA);
		wWWForm.AddField("misses", string.Empty + FNPFEOPCHHJ);
		wWWForm.AddField("replayData", string.Empty + FBDLGEIDEDA);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + s + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
	}

	public static List<PlayerTip> EAGFIMBCDCP()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	private IEnumerator PEPBPLCDPEH(bool HOCAOEIDOEL = false)
	{
		yield return new WaitUntil(() => LocalizationService.Instance.inited);
		if (GameManager.IsOffline)
		{
			isLoaded = true;
			FNNKEJFCOPO = new List<Ban>();
			AHJIKFNJJNA = new List<Map>();
			HEECFLEMGOP = new List<PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
		}
		else if (HOCAOEIDOEL || AHIIEMAHBFE < DateTime.Now)
		{
			string url = Singleton<GameManager>.Instance.CreateServerURL(serverStatusUrl);
			WWW wWW = new WWW(url);
			yield return wWW;
			if (!string.IsNullOrEmpty(wWW.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Connection error: " + wWW.error, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			ServerResponse serverResponse = JsonConvert.DeserializeObject<ServerResponse>(wWW.text);
			if (serverResponse.status == 1)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null);
			}
			if (serverResponse.status == 2)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(serverResponse.statusMessage, "#tryagain", delegate
				{
					ReloadServerInfo(true);
				}, "#exit", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
				yield break;
			}
			int num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
			if (num < 0)
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Outdated version. Please restart the game to get lastest updates.", "#later", delegate
				{
				}, "#restart", delegate
				{
					Singleton<GameManager>.Instance.ExitGame();
				}));
			}
			WWW wWW2 = new WWW(string.Concat(str1: SteamUser.GetSteamID().m_SteamID.ToString(), str0: Singleton<GameManager>.Instance.CreateServerURL(serverDataUrl)));
			yield return wWW2;
			if (!string.IsNullOrEmpty(wWW2.error))
			{
				Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW2.error);
			}
			ServerDataJson serverDataJson = JsonConvert.DeserializeObject<ServerDataJson>(wWW2.text);
			foreach (FastPlayersRank playersRank in serverDataJson.playerRanksTable.playersRanks)
			{
				try
				{
					SetLoadedRank((CSteamID)ulong.Parse(playersRank.s), playersRank.p);
				}
				catch (Exception)
				{
				}
			}
			TeamJson teamTable = serverDataJson.teamTable;
			foreach (ulong dev in teamTable.devs)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)dev))
				{
					PJCIDKMPHDD[(CSteamID)dev].isDev = true;
				}
			}
			foreach (ulong moderator in teamTable.moderators)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)moderator))
				{
					PJCIDKMPHDD[(CSteamID)moderator].isModerator = true;
				}
			}
			foreach (ulong item in teamTable.team)
			{
				if (PJCIDKMPHDD.ContainsKey((CSteamID)item))
				{
					PJCIDKMPHDD[(CSteamID)item].isTeam = true;
				}
			}
			BanListJson banList = serverDataJson.banList;
			FNNKEJFCOPO.Clear();
			foreach (Ban ban in banList.bans)
			{
				FNNKEJFCOPO.Add(ban);
			}
			MapsListJson mapsList = serverDataJson.mapsList;
			AHJIKFNJJNA.Clear();
			foreach (Map map in mapsList.maps)
			{
				AHJIKFNJJNA.Add(map);
			}
			PlayersTipsJson playersTips = serverDataJson.playersTips;
			HEECFLEMGOP.Clear();
			foreach (PlayerTip tip in playersTips.tips)
			{
				HEECFLEMGOP.Add(tip);
			}
			PlayerServerData playerServerData = serverDataJson.playerServerData;
			bgURL = playerServerData.bgURL;
			Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
			AHIIEMAHBFE = DateTime.Now.AddSeconds(ranksUpdateTimeoutSeconds);
			Debug.Log("[RanksSystem] Ranks updated. Next update: " + AHIIEMAHBFE);
			isLoaded = true;
			KAOIOJBHFOD();
			yield return StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
	}

	public new void JIJPHEDDIHC()
	{
		base.Awake();
		DebugCommands.GLEFOHOMBFC().GIALDAIHBBD("EnableRankedNotificationsToggle", MIONODPCAFD, "_MatrixSize", "workshop.", true);
	}

	public void ReloadServerInfo()
	{
		StartCoroutine(PEPBPLCDPEH());
	}

	public static List<PlayerTip> GetTipsList()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	public void BEEPICMONOD()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.CEKEOJDAEOD("player.licenceaccepted", 0) == 0)
		{
			StartCoroutine(BLJMABEIKGD());
		}
		isRankChanged = true;
	}

	private IEnumerator CJELLDGCDEO()
	{
		GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			yield break;
		}
		CJDDPDGBLNM = 0;
		int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1);
		if (@int == -1)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
			rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID());
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
			GPNKIEPLHNJ = false;
			yield return new WaitForSeconds(5f);
			CloseRanksChanges();
			yield break;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).place - @int;
		if (CJDDPDGBLNM < 0)
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
		}
		else
		{
			messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
		}
		string loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
		int num = @int;
		int place = GetLoadedRank(SteamUser.GetSteamID()).place;
		string text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
		rankText.text = text;
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(rankUpdateCanvas, true));
		yield return new WaitForSeconds(0.25f);
		int num2 = 1;
		while (num != place)
		{
			num += ((CJDDPDGBLNM >= 0) ? num2 : (-num2));
			text = "<color=#" + Helpers.ColorToHex(GetRankColor(num, true)) + ">" + loadedSteamPlayername + "#" + num + "</color>";
			rankText.text = text;
			float num3 = Mathf.Abs(num - GetLoadedRank(SteamUser.GetSteamID()).place);
			float seconds = 0f;
			num2 = Mathf.RoundToInt(num3 / 10f);
			if (num2 < 1)
			{
				num2 = 1;
			}
			if (num3 <= 1000f)
			{
				seconds = 0.001f;
			}
			if (num3 <= 100f)
			{
				seconds = 0.005f;
			}
			if (num3 <= 50f)
			{
				seconds = 0.01f;
			}
			if (num3 <= 20f)
			{
				seconds = 0.02f;
			}
			if (num3 <= 10f)
			{
				seconds = 0.03f;
			}
			if (num3 <= 5f)
			{
				seconds = 0.05f;
			}
			if (num3 <= 2f)
			{
				num2 = 1;
				seconds = 0.1f;
			}
			if (num3 <= 1f)
			{
				num2 = 1;
				seconds = 0.2f;
			}
			if (GPNKIEPLHNJ)
			{
				yield return new WaitForSeconds(seconds);
			}
		}
		GPNKIEPLHNJ = false;
		yield return new WaitForSeconds(5f);
		CloseRanksChanges();
	}

	public static void KLPPDPJFMDE(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].IEGJMMDEDCH(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	public static Color GCOPNCEDLCP(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "You need to have a child LayoutGroup content set for the list: ";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= -111)
			{
			}
			if (JMICLAEOFNP <= -109)
			{
			}
			if (JMICLAEOFNP <= 71)
			{
			}
			if (JMICLAEOFNP <= 117)
			{
				mLPCOMHPPNH = "_TimeX";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public IEnumerator CFGMHNBNPFB(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("mapid", string.Empty + CBOLFPGKALK);
		wWWForm.AddField("gamemode", string.Empty + (int)MHGOFBOPNLG);
		wWWForm.AddField("maphash", JKGOFJKFDED);
		wWWForm.AddField("score", string.Empty + EPLJLGAIJCM);
		wWWForm.AddField("accuracy", string.Empty + LODDNOOJFPA);
		wWWForm.AddField("misses", string.Empty + FNPFEOPCHHJ);
		wWWForm.AddField("replayData", string.Empty + FBDLGEIDEDA);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + s + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			ReloadServerInfo(true);
		}
		else
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(SubmitScore(CBOLFPGKALK, MHGOFBOPNLG, EPLJLGAIJCM, LODDNOOJFPA, FNPFEOPCHHJ, FBDLGEIDEDA, JKGOFJKFDED));
			}, "#close", delegate
			{
			}));
		}
	}

	public static Dictionary<CSteamID, PlayersRank> LKFLELLCLAN()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	public int GetRanksChange()
	{
		return CJDDPDGBLNM;
	}
}
