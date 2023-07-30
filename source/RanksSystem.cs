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

		public void BJIENEBCOMH(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public string CBLDFNAOJMG()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void CMIJPDHDMMG(int DPNHODJHGJL)
		{
			_003CMMDKNNCMDLL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int LNOLHBHEKDB()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void DLCOJPPKOGE(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EPDPEAAAFOG(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MHPDKEAKPII(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int NIJIOFLCEPG()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void GLPDGHFCAMO(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MLAPBHHBHEG(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HNDFGAAOCLM(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		public void MBELMLJGFMI(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public void LOFBICDLBJN(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MADAJPAGCGJ(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PLNPOBCFNBA(int DPNHODJHGJL)
		{
			_003CMMDKNNCMDLL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int IAFMPKGIJLO()
		{
			return _003CMMDKNNCMDLL_003Ek__BackingField;
		}

		[SpecialName]
		public void ABDHLEECCEB(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float CFEPFBBMDBI()
		{
			return _003CGBELECOEGLP_003Ek__BackingField;
		}

		[SpecialName]
		public int DEADAOICFMA()
		{
			return _003CMMDKNNCMDLL_003Ek__BackingField;
		}

		[SpecialName]
		public void DFLDILJCPBN(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DNEABDDMHOF()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public void BJJEDOAKDFM(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EOPGHMFJENJ(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float IAKDNMLEEHJ()
		{
			return _003CCDPFHLLMKJF_003Ek__BackingField;
		}

		[SpecialName]
		public float HMMHCFHODJN()
		{
			return _003CCDPFHLLMKJF_003Ek__BackingField;
		}

		[SpecialName]
		public string CJOOIBOMGGN()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public void DFLFKOFFFPL(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AFFMIGIMCNC(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AHHHKMKANEF(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KKLKKPNKMEI(float DPNHODJHGJL)
		{
			_003CCDPFHLLMKJF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JFHCOMMAJHG()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void LJJEKABIDOL(float DPNHODJHGJL)
		{
			_003CCDPFHLLMKJF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JLMJMFBPONP()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public int CALGBDALLAE()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public float CLMDLPPACGJ()
		{
			return _003CMBMMFCIJMBL_003Ek__BackingField;
		}

		[SpecialName]
		public string FNLDKAGBKOO()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public float MLCKMFFMMIA()
		{
			return _003CCDPFHLLMKJF_003Ek__BackingField;
		}

		[SpecialName]
		public float OJJBFGMILJG()
		{
			return _003CCDPFHLLMKJF_003Ek__BackingField;
		}

		[SpecialName]
		public void LIMPHAIOJLI(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
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
		public void PFFKLAGCJED(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PKGLEONPJCH(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LMIFOGHOKJF(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BJFKDALMALJ(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GOGNJCMKBBG(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BGHONONAIBA(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		public void JANFPDOHFKO(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public string AIJOGKDGFMN()
		{
			return _003CJLPMPKAGJJM_003Ek__BackingField;
		}

		[SpecialName]
		public void PNHBDFBGAPJ(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LCILMEFCCLC(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHIODOOCDPE(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PJHCMGFHABE(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float GHJBLMFIIHD()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public float FAJAEJBPMIF()
		{
			return _003CMBMMFCIJMBL_003Ek__BackingField;
		}

		[SpecialName]
		public void EBFABGGAFFA(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float ENCNLNIIHLG()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public string PNGOKIPPADP()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void PIPPHKIFCKK(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OFBEFEGADLP(float DPNHODJHGJL)
		{
			_003CCDPFHLLMKJF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MCPKLBJJMDA(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GBFJGDJPGPI(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BONPPCHJDFM(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NGAJGMGAGGP()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}

		public void JLKNMGOHLOJ(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			BGHONONAIBA(DateTime.Now.ToString("_Value6"));
			ALPBACEOLHK(EPLJLGAIJCM);
			checkpointsUsed = EJBAOLHHOEK;
			accuracy = LODDNOOJFPA;
			MADAJPAGCGJ(FNPFEOPCHHJ);
			comboScore = NMEHALJBEFC;
			penalty = HKNBDMAPEHC;
		}

		[SpecialName]
		public int GJMPBECKHFH()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GDOCAHHBAFN(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float AGIKHCPNANF()
		{
			return _003CMBMMFCIJMBL_003Ek__BackingField;
		}

		[SpecialName]
		public string PBLDNGDKBKE()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		public void IFMNIFDGBGO(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public string IMCEADLKDGG()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void HGPKEKLCCAC(float DPNHODJHGJL)
		{
			_003CGBELECOEGLP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NLHGKKNPKCC()
		{
			return _003CKPCNOKBIIOE_003Ek__BackingField;
		}

		[SpecialName]
		public string LIMHGJHMEIH()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		public void PLGDEKPHLIP(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public void MJLBDHFAKNN(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJEDEKOJELG(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		public void PFCJDBINLCE(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			LMIFOGHOKJF(DateTime.Now.ToString("closed"));
			ALPBACEOLHK(EPLJLGAIJCM);
			checkpointsUsed = EJBAOLHHOEK;
			JDDOCEPCCHF(LODDNOOJFPA);
			PFFKLAGCJED(FNPFEOPCHHJ);
			EOPGHMFJENJ(NMEHALJBEFC);
			LJJEKABIDOL(HKNBDMAPEHC);
		}

		[SpecialName]
		public string AOMNKJBFOGO()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public string AAFILGHHBAJ()
		{
			return _003CKPCNOKBIIOE_003Ek__BackingField;
		}

		public void RecordAction(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		public void DDKPHKAJMNE(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			finished = DateTime.Now.ToString(" PhotonView: ");
			ALPBACEOLHK(EPLJLGAIJCM);
			checkpointsUsed = EJBAOLHHOEK;
			GOGNJCMKBBG(LODDNOOJFPA);
			MCPKLBJJMDA(FNPFEOPCHHJ);
			comboScore = NMEHALJBEFC;
			KKLKKPNKMEI(HKNBDMAPEHC);
		}

		[SpecialName]
		public string DGLGCCBNHLG()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public int KCJBOFKAADB()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public string GCMOGAALNGB()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}

		[SpecialName]
		public string LGMCPNBPHII()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}

		[SpecialName]
		public string HKBEEPDHGAE()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void GLLOMLGEBDI(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EHCBMNLDFII(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ALPBACEOLHK(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MPKHOMHACCF(float DPNHODJHGJL)
		{
			_003CGBELECOEGLP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DBKDNPLCCMG(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IHIJPMDIFFH()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public void OGHAAHHAFMN(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GKFFHIFMEBB(string DPNHODJHGJL)
		{
			_003CKPCNOKBIIOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHKIMJJEFMM(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int AKDDODHNHCE()
		{
			return _003CMMDKNNCMDLL_003Ek__BackingField;
		}

		[SpecialName]
		public float JOCIMHAMBGN()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int KICOACPDBPJ()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public string NKOHGBHDDHG()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void LHPCICIHDIF(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OPIMFPKLNEA()
		{
			return _003CKPCNOKBIIOE_003Ek__BackingField;
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
		public string IEPEMANFDGL()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}

		[SpecialName]
		public void IOJGPKKOIGD(float DPNHODJHGJL)
		{
			_003CGBELECOEGLP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JIEDOLNHJMJ(string DPNHODJHGJL)
		{
			_003CGIBPMNLKNAA_003Ek__BackingField = DPNHODJHGJL;
		}

		public void NHEGCLCIJLK(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			playerActions.Add(new PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		[SpecialName]
		public string ACFEDJHDNMJ()
		{
			return _003CKPCNOKBIIOE_003Ek__BackingField;
		}

		[SpecialName]
		public void JDDPKNNLCNN(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int ECGAGDNMAFH()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public float OKBEACOIECA()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void NFMKEAPONJE(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BCNEDOHHIHH(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FAACKMCMOMM(float DPNHODJHGJL)
		{
			_003CCDPFHLLMKJF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LJDAHHMHIDG(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BOPEBLHDLBH(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KLNPLEKHDAL()
		{
			return _003CGFBGFMGKKOL_003Ek__BackingField;
		}

		[SpecialName]
		public void JDDOCEPCCHF(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IPCAKCHOGLF()
		{
			return _003CGIBPMNLKNAA_003Ek__BackingField;
		}

		[SpecialName]
		public void HPFMPBLJEKN(float DPNHODJHGJL)
		{
			_003CMBMMFCIJMBL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float ALODDNCJDGF()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public float LECBDGPMHBD()
		{
			return _003CGBELECOEGLP_003Ek__BackingField;
		}

		[SpecialName]
		public int HNOFAEAPPAL()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void PKGEFKIAMOE(string DPNHODJHGJL)
		{
			_003CGFBGFMGKKOL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CNJGJLAHMPN(string DPNHODJHGJL)
		{
			_003CJLPMPKAGJJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CLAAAJPOBGL(string DPNHODJHGJL)
		{
			_003CCFNGABCIAOD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NEIFHFLJNJA()
		{
			return _003CCFNGABCIAOD_003Ek__BackingField;
		}
	}

	public class PlayerAction
	{
		public float time { get; set; }

		public string data { get; set; }

		[SpecialName]
		public float EPMDKGHDLLC()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float MFFDNFIEBGB()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void LEJKJDIIPKA(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EHFPKFCNOEI(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float HBIECFLHMKE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void LODEFMBEEGA(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GDIPGNMFJDE(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IIFKHLLKHKJ()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void ICMMKLCKDAA(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JJBFLGMHNAP(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float EEICJPKHAJF()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string GMMGOAHMMMP()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float NKBENMLIAOG()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string FMLOPIBCLNP()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void PEONMPPIDPB(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FLBAKNBIDFE(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GCIDHODLCLA(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float PEDOAPOIDBC()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		public PlayerAction(float EHHBHEJBHNG, string NOJGGCLPPAM)
		{
			time = EHHBHEJBHNG;
			data = NOJGGCLPPAM;
		}

		[SpecialName]
		public float DNBNEJAFDDH()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string AICNNNBKBLA()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void NBCCDEPIFON(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CLNPNGCGFEK(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string ADDEBGMJCHD()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public float PJDDGGNJDBH()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void PLFLBJGECAN(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float AAADKHFAGPC()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public float DBLPHOHEDBM()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void KLIBDEPDIBB(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NGIKPEFMFFN(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HKHMFCGAIPD(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CKDHANKHHBF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HIKNMAFMEGN(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EGLBKPNBGMC(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JGNFBCLJHGP(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GBHPJOLOHNK(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IELCKJLIPBG()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string BHBIKOHJFLL()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void LOKEMPIAHJN(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float PICMNFAGCBJ()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string LPJPADOCDBF()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void INMPGKLKFKO(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PENICFIICBF(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PMEKHNPOAKJ(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float LFFLJCOIKDE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void PMHHEGALOBI(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float PDLELMIFOPA()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string BPNMOLIBPNI()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void KDGHEGEPFLD(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float JFKCAFGHIOE()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void OGCEJCPGKLA(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float BOJHGCFKCAA()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public void FFDCNBPGHMH(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string EJHIBBJLFJC()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void PKKGKBDBLOM(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KMBMKHBLCEF()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public void OMOEJJKAMFH(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EJMBHJOCLPO(string DPNHODJHGJL)
		{
			_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LJKCFPKGNAG(float DPNHODJHGJL)
		{
			_003CEBONJCKKKID_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float CFCPDIBJCPI()
		{
			return _003CEBONJCKKKID_003Ek__BackingField;
		}

		[SpecialName]
		public string CCOMFLCCGPF()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
		}

		[SpecialName]
		public string MIAHCJNCOEH()
		{
			return _003COEBNPBFJGNK_003Ek__BackingField;
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
		public void FJHBLOPBMBI(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong EFEMONFHGDB()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public float JKHMAANKIGC()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public float MHBHACCIDFH()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void PNDMHBGMJKO(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEJGPGBDOHD(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JIHGILIJCPL()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public float NLJJAAPCDDA()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void NOCAIABOION(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong BOKCLCGANFO()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void IOCLKKFPJJK(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float KPBEMENKEKG()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public void FBKDBPIILAC(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float MKCPLKNJCLB()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void COIMDNBCFMO(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DMADMGOMCAK(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LJFKOAAIKPN(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float PBENKNHJPKD()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public int FDMODBMKMKG()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		public PlayersRank(ulong GDOHPDHLPBC, int JMICLAEOFNP)
		{
			steamID = GDOHPDHLPBC;
			place = JMICLAEOFNP;
		}

		[SpecialName]
		public float BGLPAHKJDHP()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void FKPPLHKNAMH(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JNDHGJCKKHN(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int INIGKHLOKCD()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public int OOJDGAKENIJ()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public float FKMEBGKPILI()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public string FMHANMFCCAJ()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public int GODOLFFCAIL()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void CFGNJBJMGJP(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MGGEFAJNMOF(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float JFPFCCLKBFB()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public string PGFFKCFKNDB()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public int BIOCCNINILO()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void KCCBFNPCAKD(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BMIFMPJPOJF(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CHPLBLCNFBJ()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public void MKFBOAJLADK(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int AKPPHHNEAHG()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public float NOANKOBDLOG()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void JPEOLNMCCBJ(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JLFFINGLMNN(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BPLGFNBPGBN(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float PDLAJOHNLIF()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void MCDENJGINOI(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KAPEFEFHCOM()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public int GABCIGIFNCK()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public float GOOBJOFKKMA()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public ulong GGGKBGJAGLF()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public float FHICEAIAANG()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public string PMPEIJJBLNB()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public ulong JNNPODBHMIL()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void DCJLLBKDBKL(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DINJHGPMNAJ(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JLMNNFAHLKB(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HJKEDOKNJID()
		{
			return _003CINOGKDMPHOF_003Ek__BackingField;
		}

		[SpecialName]
		public void MGFOKCDJNAC(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JFEKLCFGMCA(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MBKCAGCFALG(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float FNGNGBJGIHO()
		{
			return _003CHKGAAOFNHED_003Ek__BackingField;
		}

		[SpecialName]
		public void PABLALFBLBB(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float HMHLBELOLNH()
		{
			return _003CJAJBFAMAHFB_003Ek__BackingField;
		}

		[SpecialName]
		public void GAIMCHGPMFB(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JCEEEPJOKJI()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void LLPELCPHBEB(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GGFBIJNNAEP(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float KOJMCKIINDJ()
		{
			return _003CBAKCNHNMHPE_003Ek__BackingField;
		}

		[SpecialName]
		public void MPJNOMNHEBN(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BAKNHFPGBCH(string DPNHODJHGJL)
		{
			_003CINOGKDMPHOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MHCEAHACOHL(float DPNHODJHGJL)
		{
			_003CHKGAAOFNHED_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ANLMINBJIMP(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PBENMAHABIA(float DPNHODJHGJL)
		{
			_003CBAKCNHNMHPE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong CFDMKBKHDEE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void HFFBPHPNILL(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong DEBFMOBCAPB()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void GOPCGGLDIGK(float DPNHODJHGJL)
		{
			_003CJAJBFAMAHFB_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEIHFCDHFCC(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FDDDKEFILFB(int DPNHODJHGJL)
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
		public int KKOJAPEGKOM()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void HDKEOKBCBOB(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BNIPNGIBGKM()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void KPMCNDNCGGN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DNGEOFMDPDA(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JODJNNPECOE()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void AJBKONEFHGF(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CALKPKGCALB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void FGFDEBNELJG(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MHBNAEOCMOJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void PJBACNPGHNJ(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IOJAHNIHECG(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FCCAACIBAHM(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PBOHOPLMEPE(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNAEOOEDGLC(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AGLIEGMNHGF(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DMPJGAJFCII()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void IMJNAFCHGMG(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MODLNOKEJJH(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMLKGOELKGE(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HGJNEFBBOPD(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ANDDLPMJFOK(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DNJMBGODJCD()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int IOEBAFCDJPP()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int HKGMCPKEADH()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void DPIPMEFIFKA(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BEEHKENLHNI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void APJKOFJGLMF(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ECELLMMHOKN(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KMEPFIOJIKJ(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GJMAMCPDIND()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int GKBNMAGHDMP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int CDMPACDKLPE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int ELKLHCBICPJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void OEPEKMCJPDI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BAIDEKMHODI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int DDPECKKAGPM()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void JOCOONDJMGD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JKEFFOIPPLD(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ABCLAAKCNOL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CEKFLJJBHEJ(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KMAICIKDDHD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GFOCOHHPKBD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KEDELIKHCHP(List<PlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JGFBLIEPAFI(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GLMPDCDHBEB()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int MBKGAGIFFNJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void OOHKLDJOFLE(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HGCNOFHHDLJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void MGLJMHMCAFK(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayersRank> OJCGOBPGGGM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int PCEHIOGJDME()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayersRank> BCPDOKIELLD()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int HABDCHOAFHE()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void AADMKKDJCEP(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class FastPlayersRank
	{
		public int p { get; set; }

		public string s { get; set; }

		[SpecialName]
		public string DBHONACDELD()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int CNPFEGKOFGD()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int CJNGDLBICKK()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int IAACMIBFBKF()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int NPCGCHMEHJM()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int POMBJIFGLBJ()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string KIDCMIMHLAG()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string IMHGCHDPCPP()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void LOEHFKKAKFN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MGKAICKOMGF(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KAFABIMCNKH(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BNDPNBKJIFM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JJIALEMJANE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void KJDEHAGHMCP(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void POHNLIAENFN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFEJAACDFLG(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NIOEEEOBLCB(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HPKOEJCIAJI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int IGFLMJFIOOH()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string EOEKNBOFMEP()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void HJGHFBPCDCF(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LIEMCNOJICK(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string ADHMAPBKJEP()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string HPDABNAKKLO()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void DAMLNJGHNDC(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LINLFNNMJIG()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string NNEKMCONCDG()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void HJLIIIHBGCG(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CGNJOJLPGBM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JAOJDBAFLFC()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int IOLBIDNPPAI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int MNJOLMGKJOJ()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void JKBJBLEMMNO(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MNPEAOAJHLM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void IEFNJACHGBI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BOCOMAFJAHF(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KEEHHILHMKE(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JMGBLPONOJG(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBIBIKOKHEI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string POEIJNHFPJJ()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int PKCKNCDEGJN()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int AEDDILAJFCC()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int NNPENOBKDDD()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string PMDLJKCHHPJ()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int ACOCHDEMPCN()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void HCKFJICGLON(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BKFFLALHONJ()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string KLLPCBJJFKM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void IAFAFDPOBLB(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HOANJPMPBHE(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CCLDBEALFNJ(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JNNMNJKHEMH(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int GBAKDEGGHKO()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string KEMMGPLKLPL()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void ENNGFIFABGF(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ADAEPICKFCJ(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KIJOCDJBMPJ()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int CFOJLCEMKAI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void EBPLLFJAPPG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BCMGDNOIMOE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void JGELONAFDFO(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LNCKCFMNOFG(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LNJPELPLICJ(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JHKOPIJCAHE(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KAIEJOIPHHI()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int FBALBBBFOAM()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string DOGNLEFOHJE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void JMKIAEHJOEF(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IMCKNPFIGAD(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BIPOKFHKNEF(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LNOJEJFKFLE()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void FLPDBPHGPDA(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int PIPCIBPHBCB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int FELLPHIKHJB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void IFDCHNBNLIC(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JAMAHEAGECP()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string ONIOLBCHKPB()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string JBDGHAOPBNN()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void DFAPLHEKEPC(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FIOHIGJDJMO(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EPJKFGMIBNN(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OGGAEFOBFFI(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EKLAFEGJGJJ(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CGJFCEOEIBL()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int IAMMNAPBCHJ()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void FEHGLBMGHEJ(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KFBCBNGLMHK(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AHKOLHNOBFM(string DPNHODJHGJL)
		{
			_003CCLBGDCMCALI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KKEEOLGODKL()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public string JHHMHPFHNCF()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public int BDMIEIAOGOB()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public int OAPGBEJEHCH()
		{
			return _003CHEOCCMLLBHL_003Ek__BackingField;
		}

		[SpecialName]
		public void KBIIIIAADAC(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string AEEODMCOMAD()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string FCIMMGEHOPI()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public string AOOKKECFMKM()
		{
			return _003CCLBGDCMCALI_003Ek__BackingField;
		}

		[SpecialName]
		public void BOMBBFKFLHJ(int DPNHODJHGJL)
		{
			_003CHEOCCMLLBHL_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class FastRanksJson
	{
		public int entriesCount { get; set; }

		public List<FastPlayersRank> playersRanks { get; set; }

		[SpecialName]
		public void JCODIALIFKB(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEPGHGAMFBB(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OEPEKMCJPDI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> MLGIKPOLNFI()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void LKEJFBDMPIE(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IGEBIKDNLCP(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PBOHOPLMEPE(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> CDDJABDDBPN()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void DFLFOPNDOMC(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int PPPDGMPDDEN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void ABCLAAKCNOL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> BHEOHENPMDD()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> KKEPKPBCODL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void INMJANCPNEP(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JIBIAGAKIEG(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BDKBCEACFNN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void LDHONOAJPIE(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNPLBKKDILI(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int LIDOIJHCBCE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void ELAKCAFAPKN(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FEMIAHHEFFO()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void MNGFCJGPCOL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JCMMPMPNIBM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IJCKOPAOMBC(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HMLKMFDCOAG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNLBBLMADLJ(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int JBGOKEDKPGP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void BLCCBONJDLO(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GBMHJPAMLAO(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HNLAFCHPNJK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int FPICOLBPCKD()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int GABKFAOBDGM()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int DJJKCGEGOJI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void ANBIDDMHEKI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int NKLACPEKBLN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void CGJICGLHDOJ(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NHOBFFLLALG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> LDNJFJEKJBJ()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int FDBFDHJLGFM()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> GBDLCPKJDPH()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> EPMKOIHMLCE()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void DIGLPMDODML(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JPOOOLAHCKI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> IPEDHHOELBK()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int ACIMBLGPGDH()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void OABDGFCAABL(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FEKPEMMBBCC(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> NMJCMBJAJAP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void AMMLJFFJOHG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> LIPKHLLILMO()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> NENBNPONPLJ()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void AHNAGKGKEBI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HIENMNHBJJK(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ECJJNDGLCHL(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> GKOBMHBJODP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> HINJGNAFJCA()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int BLMGAHICCFE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int JICCPEGDLEK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> CDGJPANOJEB()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void HFGOJMKPMAI(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PNINBMBIKOI(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> LKKMECHJAMP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int NGAACPNBKKI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> CIPLHMBJOJD()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void EJJHDLJNGGD(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> BCLNOKDJINJ()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> ANGPFGNGLGA()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void IOJAHNIHECG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> AEDIAGDNBLM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void MOHKIBKFOMI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> MPFLGJPHNBG()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void CAHNGJKLIMI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DMCIEKOLCBN(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> OJCGOBPGGGM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void BLGHPHCODOM(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EJGLFNHCEBB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> PGAMKOEGPEM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> BKNJLKIHHIM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void NNAOKKLFNCC(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KBFPAGNKLGK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void PGALNAHIGIF(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BKOMPJLOHJN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int HEBLLDMEOMB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int BDHBNIEJPJN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void PBMBDMKLAEO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> JDNDLMKFECP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void CDIJAFNLNOM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int ELKLHCBICPJ()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> ANOACKOCNKI()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void JEKHIGGIDAM(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> DNNEHNKCECL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void CLMFEPLNKLO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KCDFNJCFHEG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FMDMLHLEGBH()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void JEDIFHKCDDK(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEEGPHDCBKJ(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int HEDIACEDLON()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void JHPNGDFNPLM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AKLJGGEFHMP(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DIEMKCBGGOA(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EFGDNNPJKKD(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> EMFMOOHPPPM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> BNAMLDFHIGH()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> EPGIHOACMHP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int BBLOIBPGKBG()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void GMBIEMLCBNL(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> PMJEGEBEJCM()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void MLCCMGJJGGA(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> MLGKJIDDNDI()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int BAIDEKMHODI()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> KAPIGGCPNGO()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void KCNDJBOKEFA(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GGBEBICDGLG(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> CHHLFBODJEP()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void PCNLMAKKCGI(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int CDCGIAAFMCG()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> LJJFIPCCJEI()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public int LFONGJHAHOP()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int HHNBLGBBFPN()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void FHINPBGEEDG(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NKAHAOOAICO(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int KLAHFNMLBLB()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> OGPMKCBDBME()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void GEJHHPIHHKB(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<FastPlayersRank> GHGOCAIKELL()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void EJDLDBALNDD(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PANKGGOADFC(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BIHHMFHFMGN(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MBKJNHKGFEE()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void JLFAPJHBJDC(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BJJGGIPAJHA()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<FastPlayersRank> AMDFDCEFOOG()
		{
			return _003CAHFALFKJCNM_003Ek__BackingField;
		}

		[SpecialName]
		public void EFFJJFOFGOE(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BNKKDGPDKLA(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CLIGNPHCIBL(List<FastPlayersRank> DPNHODJHGJL)
		{
			_003CAHFALFKJCNM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MBFIOEJMFJJ(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	public class TeamJson
	{
		public List<ulong> devs { get; set; }

		public List<ulong> moderators { get; set; }

		public List<ulong> team { get; set; }

		[SpecialName]
		public List<ulong> AGGNGLEHEPL()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void NHEJIBGJNHO(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> CBHOAOBDKNH()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void LLGEELGLPAG(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> DKHIGOGGCPE()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void JALAANEIOJH(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ILGGHFLHLMD(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> IHOEJDCPNLK()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GFPLINMGAMH(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> BCCNAIPIFDH()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> IOHBBEIHJAO()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> NGGHALBCPOK()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> CIHCMHOKDAM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> GGOFACIOFGI()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> LAOCOBJAGNA()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> OECKCICAAMK()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> JICAOJIIOPJ()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void CNDNOHNFCBH(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PDHONFANLEK(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> DLIMIFBBLGM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> EDKODNGLOJA()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void MIBENNIAAJC(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> EBLKMFOEGEF()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MEFPFAOGFPB()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void IAMGHNBCGJD(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> ILEKDCLKOHK()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> AABNJJECLPM()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> AKIMLEAIFAA()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> HOIODJHNHNA()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void KPPEFHDCNBF(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> KHJGMNKCAKB()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> KCAODJBDAKL()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> JJKPCKOABHI()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> PDDBENPCFNF()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OPBGODDOAHC(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> HIBAJCDEDKO()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void LPJMGJGLIOM(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> HFIPBHHOEPM()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JKFHMFIENPP(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> LDCEJMLBAFL()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> OEOHFHLCGOC()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void IHDAIALNAON(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NFDBPFGINKK(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> JEFEEHMMCIN()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> EGHFCGAPFFH()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public void CPGGBJFDHFK(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> JMJNBNEDFGD()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void PMECFLMIPDG(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> EOMOCFEJJEK()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void FMABDJACINO(List<ulong> DPNHODJHGJL)
		{
			_003CMJLMMHJOHPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OMEHCBJLMKP(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HOFJKMJEGHL(List<ulong> DPNHODJHGJL)
		{
			_003CIDHMLBCNFIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> LKKCDHPEBNJ()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> AOCEHBAKAEN()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> MHHIBAMIJNK()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public void LNFAPPHGENK(List<ulong> DPNHODJHGJL)
		{
			_003CJPDONDOGCPK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<ulong> CNNBNHMAPNC()
		{
			return _003CJPDONDOGCPK_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> PLFGIIOEIAJ()
		{
			return _003CIDHMLBCNFIC_003Ek__BackingField;
		}

		[SpecialName]
		public List<ulong> BOILOBPIPOC()
		{
			return _003CMJLMMHJOHPJ_003Ek__BackingField;
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
		public List<Ban> INEBLADCMEM()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void LIEEFFBJLFG(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AAAKEIDDGDO(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MFBLLOKOIMK(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> FHFLGMNPILE()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void MDKNJCCJEDG(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DCPGJFJFKKC(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EDBMFOOIGIP(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LOPHNHGINED(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GPFOKENEMGN(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OHKCGMHKBNM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DBGGBNFIKEJ(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MBMEOIMKFGB(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> ODFHABLOGMO()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void DHCNJNGLCBM(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JBHBLMIIGEO(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Ban> CHKPKEFMOBG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> PEEJLDMBPGH()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> OBCKIBLCKLJ()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> HDDGAGEDLMG()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> COKJHBOGAHA()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> GNCJGOPNMMF()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public List<Ban> HGEPBAEMEIO()
		{
			return _003CIODLLMNONOF_003Ek__BackingField;
		}

		[SpecialName]
		public void OIMJACHDEND(List<Ban> DPNHODJHGJL)
		{
			_003CIODLLMNONOF_003Ek__BackingField = DPNHODJHGJL;
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
		public void IOJBCMBOOJK(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool JAABFBDLBAK()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public string LMDDGHCPDAK()
		{
			return _003CILPCCDJLHIC_003Ek__BackingField;
		}

		[SpecialName]
		public void LEOPMPFHCPJ(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong MMDJFDPIHLA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public bool GCLPAFADHMD()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public bool MENGIJNONGP()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public bool KDPDAEEFMKK()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public float IDAOGFLHIBN()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public float KNKHGMLPOOP()
		{
			return _003CFLLFAJGDFNF_003Ek__BackingField;
		}

		[SpecialName]
		public void OFBIEIEDILO(bool DPNHODJHGJL)
		{
			_003CAPEKGLMDHDK_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBKOHFAEKBJ(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HFLEJKELNHK(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool KBDPMOKONDH()
		{
			return _003CAPEKGLMDHDK_003Ek__BackingField;
		}

		[SpecialName]
		public void JNBIOOFOCEL(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool GHLGPIBJELG()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}

		[SpecialName]
		public string LFDPKHKJBMN()
		{
			return _003CPAHJOACFOFP_003Ek__BackingField;
		}

		[SpecialName]
		public void GPJKCCCAGJK(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DJHEENLEHBF(bool DPNHODJHGJL)
		{
			_003CBGEDPCLDJAM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMKJCOCFIEJ(bool DPNHODJHGJL)
		{
			_003CAHMCLGDNEOE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KDGEGPGPDED(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HCMBNLCNBGF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LANAOEFHCOK(float DPNHODJHGJL)
		{
			_003CFLLFAJGDFNF_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DOCFHJAFFCH(string DPNHODJHGJL)
		{
			_003CPAHJOACFOFP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LGHBCAAKIFH(string DPNHODJHGJL)
		{
			_003CILPCCDJLHIC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public bool NKDHAKBLODD()
		{
			return _003CBGEDPCLDJAM_003Ek__BackingField;
		}
	}

	public class MapsListJson
	{
		public List<Map> maps { get; set; }

		[SpecialName]
		public List<Map> JLIFMLEHJAH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> DLBKOMIOLPG()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> AIOPFAECONC()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void JDOGPMLHKLI(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CEPKMJFODMI(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> ELKKMDCMFGI()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> FHCLMKFHANC()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> KFBJHGMHODH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> MGCLENCJDKC()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void AJDMLBHGBAC(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> BLCFEAEBFPJ()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void GAFGJLDJCGD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHDACLOAGEL(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> ENDKCFKIOHD()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> KLJHNMCHNIH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> KKBCDFPKOMB()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void FECMGMDBIAF(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> AFCGAKHEEOE()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> CDINIEMCHCA()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> OEEDKFEMNMK()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> JHHDJMKILHH()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void LDGEKAJGMGK(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> MPNNOBNNJLP()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> HLNBCKDBJDE()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void EEMHKBMMNDE(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PJFBECOBOBL(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> BJJKMDALFCP()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void DKCNKLHBFGD(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BGBLFJDIFIB(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> IINIOFNGPPF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void CDDHDBDILGA(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CAPLJIHIIID(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> ODFHEKGEHMB()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> CIHFCCGPLPF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> BCFKJIBJJPL()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> BHFALEIHLIO()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public void BFOKNMJGKAC(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LPCDIMADAGK(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PACFCCHFFHE(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EPMMEFGCCMP(List<Map> DPNHODJHGJL)
		{
			_003CGKIGFPHDENP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Map> BIFHHDJDIPF()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
		}

		[SpecialName]
		public List<Map> CPNDKJKNOML()
		{
			return _003CGKIGFPHDENP_003Ek__BackingField;
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
		public float HEMHPKBJJPM()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void AOLAOEJNPMG(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BEBHNKOFKFJ()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public string GIJEEHIKLIJ()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void OCKOOJBLOMB(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int IBKMHHOKFOB()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void IIPFMNAGJCD(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BEPEFAIOMKH(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float FKOLDEJBGDK()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int CJILPHFNMEB()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void IADGJIKCNIM(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int ACBGMBBHEMB()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void FNPFOHBDIMC(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int EANEJLEINKA()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void KNLLLEFKAGH(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IOCLKKFPJJK(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int IKAICPGBPBC()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public string EIMPLOIFPNH()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void KDFDCJBIIHJ(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CCJJABKCNPB(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PKCOLFJIPOO(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LIEFCMEHIBF(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JFPPOCODAPK()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public int OJGCECFCOPA()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public int NGIGIFCEFDF()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public string BEMGNBNHLJK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string LFAHKCDECDC()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void FNHHKHACPAM(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CALNMKAAKLA(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string GECMOEAHKPG()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public int EBABCEKKEGG()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void ABNEHELFPHI(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BFPOONDJHCI(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CIDOFKGDDFG(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BCDDNOOGFED()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public string EIFBKJOPIFK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void CIODAEPHEBF(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int APLHNBODIGC()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void CINLECOHCHJ(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DJGKNIIMCJK(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CFDMKBKHDEE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public int APBCHKGDNFJ()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JKNAFOIHIGM(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JOBHHNLIKIB(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KJEFLKDJFDE(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float MAOGBOMEBMA()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int POJPBBODDFI()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void JPCLCMDINFD(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DNKKDOKHEIP(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JNNPODBHMIL()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void KNNGFGPDGDG(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int MKDMHJDIPOP()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public int CBPLJCPFIGL()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public void KGNILIECKHL(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NGMGNEAAOIE()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void IOPKEHNMIOM(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KDPBEFPPKNP(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MJPCBOCNHDD(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OMCAJNCDALE(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DBMLLBMLDFE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void GFOAKJOLJDP(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NMDMHCJPHFG(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HHCGKOJBAPB()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void IGGHJOLEILN(int DPNHODJHGJL)
		{
			_003COEHIIAPBGPJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBDOBJABHCG(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float HOFMEJBKMDA()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void BAAIGBGEGNH(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DOBGGOILPPO()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public void BCLNEGLLLEC(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CMMNDCDCHNJ(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MAJMPNOGECJ(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MONBPLKMEHG(int DPNHODJHGJL)
		{
			_003CDIOMDJNIGAG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int BDBODOFNAJJ()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public int HMMLAHODCNC()
		{
			return _003CDIOMDJNIGAG_003Ek__BackingField;
		}

		[SpecialName]
		public float JOCIMHAMBGN()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public float HEPPEIGCENL()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public string IKEPCACJAAK()
		{
			return _003CABAHBKJHEPI_003Ek__BackingField;
		}

		[SpecialName]
		public void NJFMLDJKKGC(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float DGMMMAAIHBB()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public int NONJJNOFONI()
		{
			return _003CBPNDCADENDJ_003Ek__BackingField;
		}

		[SpecialName]
		public int IFIIHFGLGFH()
		{
			return _003COEHIIAPBGPJ_003Ek__BackingField;
		}

		[SpecialName]
		public void OOLJMMKLIGL(string DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float ENCNLNIIHLG()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void ANJDHBEAMKJ(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MIKLMCKINBE(string DPNHODJHGJL)
		{
			_003CABAHBKJHEPI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LAAMICHIJBO(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public float AAJACMEJDAA()
		{
			return _003CEPDGGHBOLBD_003Ek__BackingField;
		}

		[SpecialName]
		public void EGFLDDIDHIA(float DPNHODJHGJL)
		{
			_003CEPDGGHBOLBD_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void INGFPFKHLAP(int DPNHODJHGJL)
		{
			_003CBPNDCADENDJ_003Ek__BackingField = DPNHODJHGJL;
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
		public void APMDBOCGKOF(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MCBMLHFLFGE(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JLKIFGDDOBC()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void AODLKOONJMM(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int FDIANCLJKLK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public int MGKNEFGHJPO()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int AJGDJLMHDDN()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void FCCAACIBAHM(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int AFOMKDLNKEK()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<Score> EJFNJBHAEJE()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void GKIJKEDPMCF(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KJIDLFIJDNL(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OBLNALCNOMI()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void NLKJIIOMAOM(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HEPJHANIIFI(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> BHANNOMPIKD()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public List<Score> OGGFOCAMODK()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void DPHOLPAMGKB(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBJBKONPGMG(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMOENAKJAMF(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LBKKAHDAGLA()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void KPMCNDNCGGN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IEPGHGAMFBB(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int PCJIEJHKKDF()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public void FMLBDEMBADD(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ODBKAEIHJCG(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int DIMFMOAFHLH()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void JIGJHHMHLLJ(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GHJKADPPKPD(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JMILFOIEDID(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public int OCIEEHCILPJ()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void GKFNMKEOPFJ(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> DBAJOAPNPML()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void LDCPGPNIEJM(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CMHMJMBMPJO(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> JCOAHFKLNEF()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public int OKKJGOOLAOE()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int MPKCCCBPPGO()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public int PKCGEMCOJGG()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<Score> FMPHCKDPPMH()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public string BACBEEAFOLL()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ECELLMMHOKN(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> DMNGCFLKMIN()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public int EOPBACHEHGH()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public List<Score> COJNLEEEPDC()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void OBENJJNMPCL(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JDLNCJFAHHF(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FICKIKOMGNM()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void PHPJJIPHAGJ(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KHGCOJMMFJN()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void DIGLPMDODML(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PEBEPIGJFCN(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJOFEBCNBKM(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string HJJNPGCIOMN()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void CACPMHFNPIO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public GameScene.GameMode MOBFJIPBMDI()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public GameScene.GameMode DIPCKICAEKH()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public int OKCNCGDCKFA()
		{
			return _003COGELODOODJM_003Ek__BackingField;
		}

		[SpecialName]
		public GameScene.GameMode FMOOIKOFKDA()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public void CIMACLGHANL(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ICMLLOLHFLK(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KIEOLEEPJIE()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public int MGJCMOLHPCL()
		{
			return _003CLLOKOKDCMJH_003Ek__BackingField;
		}

		[SpecialName]
		public void KECJJMBPEEF(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KBDENDECGNG(GameScene.GameMode DPNHODJHGJL)
		{
			_003CHOGLILLDHLN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ABJPJCOOGII(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CIKOOHEDJGC(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void JPFKMNHLKJG(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KOKCOLPEPDC(string DPNHODJHGJL)
		{
			_003CBKDALLFMPCC_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string LDNGELCENFD()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void PCEPICMAKLF(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AHCHCFMOIGM(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Score> PHADDKNBEMN()
		{
			return _003CCLGNAIHJDFI_003Ek__BackingField;
		}

		[SpecialName]
		public void FHHMPKOEDDO(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public GameScene.GameMode PBDNMEBAMPB()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public string MELMCBCAPHG()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public string ENANHMIMMJM()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}

		[SpecialName]
		public void AMHAKNIHAMC(int DPNHODJHGJL)
		{
			_003CLLOKOKDCMJH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public GameScene.GameMode AKIIGPIJACN()
		{
			return _003CHOGLILLDHLN_003Ek__BackingField;
		}

		[SpecialName]
		public void MJLMLAPCGPB(int DPNHODJHGJL)
		{
			_003COGELODOODJM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void PIHMLFBMCFG(List<Score> DPNHODJHGJL)
		{
			_003CCLGNAIHJDFI_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string PMOCEFDPLAO()
		{
			return _003CBKDALLFMPCC_003Ek__BackingField;
		}
	}

	public class PlayersTipsJson
	{
		public List<PlayerTip> tips { get; set; }

		[SpecialName]
		public void GFDMAAOENEJ(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> DCFDHCEOJIB()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void MJFEMECKIII(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BDMJCPMEMCK(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HDOIKFDPLLE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CAJHDOMFCMG(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> NGCNJEDIGHL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void FBEOKCCFKGO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LKAEMBLDMNA(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> JMGFFOJLMNA()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> GNPAOPOAPAC()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> FPPJGPNKNJM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> MJKCFMJEIFG()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> FNAMEDDIEJJ()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> FJOEHMFBAHM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> MFKFCIONKCM()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> OEJDINFOHBH()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void HDCEEDJLOEO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> ICLIMJLMNGC()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void LFODAPGHPBH(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DKHFFKGLMLE(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> JAPJIPEBIEE()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> BEBHFKGOIOL()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GCBCBDMOKFH(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> OGECAHGEJBD()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void GCBMEOGJACO(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MLPMFFFGDGM(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GLPLNBNBAAN(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBHPLDHKFGD(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> HDJKGGDBEPA()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> HBIAKHFJBBF()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> HDGHOHGFHIN()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public void IPGGCEKAHDL(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OAFADDMOHIH(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DBJLJPKFGGJ(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LKKNGBHNDMM(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HFGCEDCNIGB(List<PlayerTip> DPNHODJHGJL)
		{
			_003CMFGKDEDHPMJ_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<PlayerTip> ODJFBFDKLML()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> NOICPPLGJJE()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> NBLIFLKGMNH()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> PMFPKDJELFD()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
		}

		[SpecialName]
		public List<PlayerTip> LLIEGKMAJDN()
		{
			return _003CMFGKDEDHPMJ_003Ek__BackingField;
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
		public string BPBCLEKGHCE()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
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

		public int HEDKODDNFEA()
		{
			int num = 0;
			try
			{
				string text = CALKEOEMAJD();
				char[] array = new char[1];
				array[1] = 'ￇ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = 'y';
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
		public string LNLNKMDACLO()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string DGFFMMGLLAK()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public string LNCAGEBIAHE()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		public void DLBDGKKCEFO(int BMAEINMDAFF)
		{
			if (GetUserVote() != 0)
			{
				string text = string.Empty;
				string text2 = LNAODOPINFB();
				char[] array = new char[0];
				array[0] = '1';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[0] = '>';
					string text4 = text3.Split(array4)[1];
					char[] array5 = new char[0];
					array5[1] = '>';
					string text5 = text3.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[6];
					array6[0] = text6;
					array6[0] = ((text.Length <= 0) ? string.Empty : "_Value3");
					array6[4] = text4;
					array6[6] = "<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players";
					array6[2] = text5;
					text = string.Concat(array6);
				}
				IJEGFOIOLPF(text);
			}
			else
			{
				object[] array7 = new object[6];
				array7[1] = LNPNIFOLPMN();
				array7[0] = "Joystick1Button12";
				array7[0] = BMAEINMDAFF;
				array7[8] = "offsets";
				array7[4] = SteamUser.GetSteamID().m_SteamID;
				votes = string.Concat(array7);
			}
			Singleton<RanksSystem>.Instance.AHPIEKAGNJI(BFFNGNLBGIN(), BMAEINMDAFF);
		}

		public int CGENEJIPPEI()
		{
			int num = 1;
			try
			{
				string text = BPBCLEKGHCE();
				char[] array = new char[0];
				array[0] = '\u0006';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = 'ﾊ';
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
		public void JOHOPFECANA(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong JABENKBHJGE()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public string PDMNKBFAGAA()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		public int PIIHHBOHJLK()
		{
			int num = 1;
			try
			{
				string text = NAJDNAABNKA();
				char[] array = new char[0];
				array[0] = '\'';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = 'd';
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
		public ulong ALBJAEBLABB()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HHGBBNFFABK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public ulong BINKBJFIINK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
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

		public void KMJBGNACIED(int BMAEINMDAFF)
		{
			if (JCNIDOEENCB() != 0)
			{
				string text = string.Empty;
				string text2 = BPBCLEKGHCE();
				char[] array = new char[1];
				array[1] = 'ﾗ';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				foreach (string text3 in array3)
				{
					string text4 = text3.Split('z')[0];
					string text5 = text3.Split('ﾶ')[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array4 = new string[1];
					array4[1] = text6;
					array4[1] = ((text.Length <= 1) ? string.Empty : "]. Please verify you have this gameobject in a Resources folder.");
					array4[3] = text4;
					array4[4] = "Hip-hop";
					array4[6] = text5;
					text = string.Concat(array4);
				}
				votes = text;
			}
			else
			{
				object[] array5 = new object[4];
				array5[1] = LNAODOPINFB();
				array5[0] = "_Value2";
				array5[7] = BMAEINMDAFF;
				array5[7] = "PlayButton";
				array5[3] = SteamUser.GetSteamID().m_SteamID;
				IEHHIFMDDFL(string.Concat(array5));
			}
			Singleton<RanksSystem>.Instance.LPPMIMLDFBJ(BFFNGNLBGIN(), BMAEINMDAFF);
		}

		[SpecialName]
		public void OBDPNPEOOHF(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IICGKJMJGPI(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		public void NCCCGNKBBJI(int BMAEINMDAFF)
		{
			if (GetUserVote() != 0)
			{
				string text = string.Empty;
				string text2 = LNPNIFOLPMN();
				char[] array = new char[1];
				array[1] = 'ﾡ';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				foreach (string text3 in array3)
				{
					char[] array4 = new char[1];
					array4[1] = 'c';
					string text4 = text3.Split(array4)[1];
					char[] array5 = new char[0];
					array5[1] = 'h';
					string text5 = text3.Split(array5)[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[2];
					array6[1] = text6;
					array6[0] = ((text.Length <= 0) ? string.Empty : "_VignetteSettings");
					array6[7] = text4;
					array6[1] = "Paste events";
					array6[4] = text5;
					text = string.Concat(array6);
				}
				votes = text;
			}
			else
			{
				object[] array7 = new object[7];
				array7[0] = BPBCLEKGHCE();
				array7[1] = "_SpotSize";
				array7[7] = BMAEINMDAFF;
				array7[0] = "#ok";
				array7[6] = SteamUser.GetSteamID().m_SteamID;
				IEHHIFMDDFL(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(id, BMAEINMDAFF);
		}

		[SpecialName]
		public void PJEGGABAHBC(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJFBKKPFFMI(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NFAAADLGEGI(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong BFFNGNLBGIN()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void ADMJNAGBPOK(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KEMDNKGIDPL(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CPNNDIMDEKI()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int GGBIDCGBIOO()
		{
			int result = 1;
			try
			{
				string text = KPBJIHNKNAD();
				char[] array = new char[1];
				array[1] = 'ﾞ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[0] = 'ￒ';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						char[] array5 = new char[0];
						array5[1] = '*';
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
		public void ICHFIKLODFM(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IJEGFOIOLPF(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DCHNHOKGMND(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HIEDBNPNCID(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong DINKBGAFKAH()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public void MIIKBDIFHHK(int BMAEINMDAFF)
		{
			if (KOAFPICIJAF() != 0)
			{
				string text = string.Empty;
				string text2 = CALKEOEMAJD();
				char[] array = new char[1];
				array[1] = 'E';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text3 = array3[i];
					string text4 = text3.Split('\ufff6')[0];
					char[] array4 = new char[0];
					array4[1] = '\ufffb';
					string text5 = text3.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array5 = new string[3];
					array5[1] = text6;
					array5[1] = ((text.Length <= 0) ? string.Empty : "_LutTex");
					array5[1] = text4;
					array5[5] = "LeaderboardsButton";
					array5[1] = text5;
					text = string.Concat(array5);
				}
				IJEGFOIOLPF(text);
			}
			else
			{
				object[] array6 = new object[8];
				array6[0] = HMAEGBBBPMA();
				array6[1] = "PhotonServerSettings";
				array6[1] = BMAEINMDAFF;
				array6[4] = "_Value4";
				array6[8] = SteamUser.GetSteamID().m_SteamID;
				votes = string.Concat(array6);
			}
			Singleton<RanksSystem>.Instance.LPPMIMLDFBJ(HNGIHCKINDJ(), BMAEINMDAFF);
		}

		[SpecialName]
		public string DMDMFFKHAJA()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public string LNAODOPINFB()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public void OPIKMFKPCPP(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CADFBFFMJAL(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CCJLFDHPAPP(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong IMELEPJLJLH()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public int IPLNCBFBGFJ()
		{
			int result = 0;
			try
			{
				string text = KPBJIHNKNAD();
				char[] array = new char[1];
				array[1] = 'j';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text2.Split('L')[0]))
					{
						char[] array4 = new char[1];
						array4[1] = 'ﾼ';
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
		public void FJIGDKBCGKM(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NCGHMLACAPB(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BBDOBJABHCG(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong HLJAGNFLKFM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void NINDDAOOCKD(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CALKEOEMAJD()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string HMAEGBBBPMA()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public string FPIKMJIAMKD()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int JCNIDOEENCB()
		{
			int result = 0;
			try
			{
				string[] array = LNAODOPINFB().Split('ￇ');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text.Split('ﾗ')[0]))
					{
						char[] array3 = new char[0];
						array3[0] = 'Z';
						result = int.Parse(text.Split(array3)[0]);
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
		public void NNIAOADLJFL(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NOPNKGIJBAP()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public void GECEMHIOENL(int BMAEINMDAFF)
		{
			if (PEDLGIPINID() != 0)
			{
				string text = string.Empty;
				string text2 = KPBJIHNKNAD();
				char[] array = new char[0];
				array[1] = '\uffe3';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				foreach (string text3 in array3)
				{
					string text4 = text3.Split('*')[0];
					string text5 = text3.Split('.')[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array4 = new string[0];
					array4[0] = text6;
					array4[0] = ((text.Length <= 1) ? string.Empty : "_TimeX");
					array4[4] = text4;
					array4[3] = "Joystick1Button0";
					array4[3] = text5;
					text = string.Concat(array4);
				}
				IEHHIFMDDFL(text);
			}
			else
			{
				object[] array5 = new object[2];
				array5[1] = LNCAGEBIAHE();
				array5[1] = "...";
				array5[5] = BMAEINMDAFF;
				array5[2] = "Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall";
				array5[8] = SteamUser.GetSteamID().m_SteamID;
				IJEGFOIOLPF(string.Concat(array5));
			}
			Singleton<RanksSystem>.Instance.LPPMIMLDFBJ(ALBJAEBLABB(), BMAEINMDAFF);
		}

		public int NCPDFMFGIMK()
		{
			int result = 0;
			try
			{
				string text = HMAEGBBBPMA();
				char[] array = new char[0];
				array[1] = 'ﾈ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array4 = new char[0];
					array4[0] = 'ﾲ';
					if (num == ulong.Parse(text2.Split(array4)[1]))
					{
						result = int.Parse(text2.Split('Q')[0]);
					}
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}

		public void JOIADOMCOKG(int BMAEINMDAFF)
		{
			if (GetUserVote() != 0)
			{
				string text = string.Empty;
				string text2 = BPBCLEKGHCE();
				char[] array = new char[1];
				array[1] = '\u001c';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[0] = '4';
					string text4 = text3.Split(array4)[1];
					string text5 = text3.Split('Y')[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array5 = new string[6];
					array5[1] = text6;
					array5[0] = ((text.Length <= 0) ? string.Empty : "#ok");
					array5[1] = text4;
					array5[6] = "_FarCamera";
					array5[3] = text5;
					text = string.Concat(array5);
				}
				ICHFIKLODFM(text);
			}
			else
			{
				object[] array6 = new object[7];
				array6[0] = KPBJIHNKNAD();
				array6[0] = "_Sensitivity";
				array6[6] = BMAEINMDAFF;
				array6[7] = "Preparing content";
				array6[5] = SteamUser.GetSteamID().m_SteamID;
				IEHHIFMDDFL(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.AHPIEKAGNJI(IMELEPJLJLH(), BMAEINMDAFF);
		}

		[SpecialName]
		public string HEHHNCILLHM()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public void JMKOCDKFFAE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MLFPCJDHMCA(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KPBJIHNKNAD()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public ulong BBPGJKOIAKM()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public string MHCHGKNIODM()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int KOAFPICIJAF()
		{
			int result = 0;
			try
			{
				string text = DOMCGFLKBIM();
				char[] array = new char[0];
				array[1] = 'ﾜ';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text2.Split('\ufffd')[1]))
					{
						char[] array4 = new char[0];
						array4[1] = ')';
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
		public void IEHHIFMDDFL(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JCACLINOCAL()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public ulong GOIDBDOKIJE()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void BCJGILPIABK(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong MFGIEPLNMOF()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public string NAJDNAABNKA()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		public int FOILACEMICA()
		{
			int num = 1;
			try
			{
				string text = NAJDNAABNKA();
				char[] array = new char[0];
				array[0] = '￩';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('\u000e')[1]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public string LNPNIFOLPMN()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public ulong OOCMAKFGACK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void EKJJNMKJJDA(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MNHHIGAFBEM()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public ulong FHCOEDJFEIB()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		public void BGCDDCEMOOB(int BMAEINMDAFF)
		{
			if (GetUserVote() != 0)
			{
				string text = string.Empty;
				string text2 = CALKEOEMAJD();
				char[] array = new char[0];
				array[0] = '\u000f';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[1] = ':';
					string text4 = text3.Split(array4)[1];
					char[] array5 = new char[0];
					array5[0] = 'T';
					string text5 = text3.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array6 = new string[4];
					array6[0] = text6;
					array6[0] = ((text.Length <= 1) ? string.Empty : "ready");
					array6[1] = text4;
					array6[1] = "ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ";
					array6[4] = text5;
					text = string.Concat(array6);
				}
				DOCIGLDJGAK(text);
			}
			else
			{
				object[] array7 = new object[2];
				array7[1] = HMAEGBBBPMA();
				array7[1] = ".g";
				array7[6] = BMAEINMDAFF;
				array7[1] = "Vertical";
				array7[0] = SteamUser.GetSteamID().m_SteamID;
				IJEGFOIOLPF(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.AHPIEKAGNJI(KEGJGPOECHA(), BMAEINMDAFF);
		}

		[SpecialName]
		public string NFHDFIILPEE()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		[SpecialName]
		public void HGJLBBNDIEE(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		public void GFKGBAFAOBM(int BMAEINMDAFF)
		{
			if (GGBIDCGBIOO() != 0)
			{
				string text = string.Empty;
				string text2 = NAJDNAABNKA();
				char[] array = new char[0];
				array[0] = 'ￜ';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text3 = array3[i];
					char[] array4 = new char[0];
					array4[1] = '\ufff9';
					string text4 = text3.Split(array4)[0];
					string text5 = text3.Split('ﾜ')[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text5))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text6 = text;
					string[] array5 = new string[2];
					array5[0] = text6;
					array5[0] = ((text.Length <= 0) ? string.Empty : "/music");
					array5[1] = text4;
					array5[2] = "4,28,true,0";
					array5[4] = text5;
					text = string.Concat(array5);
				}
				DOCIGLDJGAK(text);
			}
			else
			{
				object[] array6 = new object[3];
				array6[0] = NAJDNAABNKA();
				array6[0] = "Hex value #RRGGBB";
				array6[5] = BMAEINMDAFF;
				array6[1] = "_Near";
				array6[5] = SteamUser.GetSteamID().m_SteamID;
				IJEGFOIOLPF(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.AHPIEKAGNJI(id, BMAEINMDAFF);
		}

		[SpecialName]
		public string EKOCIHBGIOK()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		[SpecialName]
		public void PJLIBFOCJPB(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong DOKGKLEGKDK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public void DOCIGLDJGAK(string DPNHODJHGJL)
		{
			_003CDMAKNKNPHFO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong ILJPAGKMFBP()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void OBHIJHNJCAE(string DPNHODJHGJL)
		{
			_003CKNKMBLBALJN_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong KEGJGPOECHA()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void LBBLBGPKFGJ(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DOMCGFLKBIM()
		{
			return _003CDMAKNKNPHFO_003Ek__BackingField;
		}

		public int KGLMHALOHEH()
		{
			int num = 1;
			try
			{
				string text = LNAODOPINFB();
				char[] array = new char[0];
				array[1] = 'c';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[0];
					array4[1] = '\u0001';
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
		public void LKAPNHPONCH(ulong DPNHODJHGJL)
		{
			_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string FDBGLDOBMEF()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}

		public int IJAMOJACNEA()
		{
			int num = 0;
			try
			{
				string text = LNCAGEBIAHE();
				char[] array = new char[1];
				array[1] = 'l';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[0];
					array4[0] = 'ﾭ';
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
		public ulong JCBEBJBFPIN()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public ulong HNGIHCKINDJ()
		{
			return _003CEACCOCFNPIG_003Ek__BackingField;
		}

		[SpecialName]
		public void KKLNBMEBOEP(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
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

		public int PEDLGIPINID()
		{
			int result = 0;
			try
			{
				string[] array = NAJDNAABNKA().Split('I');
				string[] array2 = array;
				foreach (string text in array2)
				{
					ulong num = SteamUser.GetSteamID().m_SteamID;
					char[] array3 = new char[0];
					array3[1] = '\u0005';
					if (num == ulong.Parse(text.Split(array3)[0]))
					{
						char[] array4 = new char[0];
						array4[1] = 'ﾘ';
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

		public int KJDDPBDIEGD()
		{
			int num = 0;
			try
			{
				string text = NFHDFIILPEE();
				char[] array = new char[0];
				array[1] = 'p';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split('i')[0]);
				}
				return num;
			}
			catch (Exception)
			{
				return num;
			}
		}

		[SpecialName]
		public void JJLJNALPOPF(string DPNHODJHGJL)
		{
			_003CMMJCIPEEEEG_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public ulong PGAMGLDIIKK()
		{
			return _003CCFJPIFLLIPH_003Ek__BackingField;
		}

		[SpecialName]
		public string MMGDBAPGGKG()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		[SpecialName]
		public string FOJAGLEIBCN()
		{
			return _003CKNKMBLBALJN_003Ek__BackingField;
		}

		public int BOGIPHBLAFD()
		{
			int num = 0;
			try
			{
				string text = NAJDNAABNKA();
				char[] array = new char[0];
				array[1] = '\u000e';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					char[] array4 = new char[1];
					array4[1] = 'ﾼ';
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
		public void FMJIHEDNCPD(ulong DPNHODJHGJL)
		{
			_003CCFJPIFLLIPH_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string POJIOBLCHPI()
		{
			return _003CMMJCIPEEEEG_003Ek__BackingField;
		}
	}

	public class PlayerServerData
	{
		public string bgURL { get; set; }

		public List<Challenge> activeChallenges { get; set; }

		[SpecialName]
		public string AHHLIHAFPKO()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string FNJLEDBIHFG()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void CHNBBOBBLMC(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IBDIMOJBOOO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MMEFJMKDELM()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void ODLDGDHKPMM(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> KPMJODPMDFF()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void OPGFKHDIFGP(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IBCOKDEPMBM()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> KIAHNKMKCKG()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void DLJKLBEHNJF(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EDKECHCLPDL(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void ADALEALPLJO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> LNJFLKNHGHL()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string HBLMOLJGCGO()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void ONBIKGBOEFC(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BHKDLEMFGJB(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OLJCLGADGHC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void JNPIGMACANC(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> BKFELAKDMKF()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void BGOMNNFPDBO(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IBDLDCFFBBA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KADABODEKCB(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> CFJPCIHEJJP()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void JMGAMCAIDDG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string OJJIPKOPICG()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void DODMKDFEOEE(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> CCGGHKCFHPI()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void AAODFMMJBOG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JGJHCOIFAFI()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void BILPODNLOMC(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void AJOJCNJDNMH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NLDGLOHDEMH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MMCBEMGKHBE(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MKGNHHLGPHH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> LAGHEDLMGFA()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void EANCGFNHPEC(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GBPMAFFHBEP(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GLKGFOIDCHP(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string MOJGGOMPJMC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string MEDPCIBIGMJ()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void EPKOGIAIPGI(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EOBMHGEIEBA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> CMGGBMCDKKA()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> NCHJBEJKGDD()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string APFNPFCNHHL()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void PHEFJFICNED(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void BCOIACNMHLA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BBFMBJNBCBL()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void BHCHJHAEFAB(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> HNHPKDDJDPJ()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string LFDJJBELPMA()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void EBMEGGHCEEJ(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> ADDHFANGKFG()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void DNLIAHNGOGO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IGPBDCHILBP()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void LEPAINJBEDC(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DKHPDJMJPFG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string AOMAMCKMAOJ()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void MCBBPKEOAPE(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EHGFDBLOOEH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EFMGCDADIPA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void HEDCOEKLEEM(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FECJBKMDFJI(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NHGKDMBHKJB(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LCFPJLHIBBP(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> LFAEBBCNNHK()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void NCHPHKIALLG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> ONBAJFKPBEN()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void JAIEFAKAJNG(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> DAPKGHJPLHC()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string FBGGBFDNJLH()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void MNPIJJGLHIO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BAELHLJNABK()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void BMHOKHHIJFO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> ABKOHHBBAPK()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string GIMOOBPENIC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> NBCODGNDCIO()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string OFIAEJHNCAD()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string AOOIONEMBLP()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void ABENKDJJECL(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IPPBHNBBCOC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void ONMAFNELLLI(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CJDLIAHKBDM(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EEBIDANLCGM(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DIDELGKFHGB(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> GEGPENGJGGP()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> OMHLPGONKBA()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void ALELDFCKBKD(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EJLIHPEMJDD(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string POJMJIJJHEO()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void HNHPJAFDOFF(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void GCNPAPODLLO(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> CMONMAHPNGN()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void KPLNPILHBCO(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EKNMJEJOAAA(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FBFMLAPNJGJ(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string NNOHJOGOALC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> NDNHHFHFIIJ()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> PAIIIJIBECN()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void CPIDDCNDBEN(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KCLIANKMGND(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OJLLJBDPGEK(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FDGJBLHPHIA(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string CFEPFCHIFHL()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void FDEMEKKEGGG(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IOLDJODBLJJ()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void MDFJINGONOO(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void NNKFLCIOMAF(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string JGPCGNPECPA()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void JEGFLJKMLLF(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FFMPKHDAODL(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FGJGMHGOOCI(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void KKGHHLLHPPN(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void IMDFLCJFPNB(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MLHPHDKEBOL(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CBIHDPDDLCD(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string IACKLGDDACC()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string BNOFIEPHPJF()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void PBJMJICPHKE(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void DPJNLJJCKHH(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string KMBAIOJLMFD()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string AFAJJKEGOJN()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string MDLJIFJFKLI()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> NMGKDLCCGKF()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void JMBGOOGGLPK(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void LBFOEIICNOI(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string DNGAKMEFFJM()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string MFHBKEHBMBB()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public List<Challenge> PDPCKOLDHJG()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public void MICLCGJMINP(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void CHEANDMNBOF(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void FGIPAAKAEEF(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EMEJLOCEGOG(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void OICMLAEDFNL(string DPNHODJHGJL)
		{
			_003CNHDAELAGOIA_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public List<Challenge> GFAHIAHPIHB()
		{
			return _003CNCHDNCHHMDE_003Ek__BackingField;
		}

		[SpecialName]
		public string AIGEAHLELBA()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public string LPOFGBBFKJM()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
		}

		[SpecialName]
		public void JCLMLCMNFAD(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EIBEEIHJOCP(List<Challenge> DPNHODJHGJL)
		{
			_003CNCHDNCHHMDE_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public string BKEJOLEKDKK()
		{
			return _003CNHDAELAGOIA_003Ek__BackingField;
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
		public MapsListJson MEEFHKKOGJL()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public void IKBFKNCFMGH(MapsListJson DPNHODJHGJL)
		{
			_003CAODPKEOADIP_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public TeamJson DKHPAENCMFH()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public FastRanksJson BMKKLPJFEAI()
		{
			return _003COBHCFKCBFIE_003Ek__BackingField;
		}

		[SpecialName]
		public void FCKIOCHGEBE(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayersTipsJson KFLIMMBBHIB()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public void CEKGIFMNDHG(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public PlayersTipsJson OEMCLMNGCGB()
		{
			return _003CDIFDJNONGGL_003Ek__BackingField;
		}

		[SpecialName]
		public PlayerServerData MHFHEMALMPB()
		{
			return _003COPDMJCEPHBM_003Ek__BackingField;
		}

		[SpecialName]
		public void NFNELPIGHNF(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public MapsListJson PBBEAJKOLLB()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public TeamJson EMJDFMKGDJL()
		{
			return _003CMHLNPPIHHAM_003Ek__BackingField;
		}

		[SpecialName]
		public void CEDKGLJKCBF(PlayerServerData DPNHODJHGJL)
		{
			_003COPDMJCEPHBM_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void EIKOALGIBIB(PlayersTipsJson DPNHODJHGJL)
		{
			_003CDIFDJNONGGL_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public void MCINOGDLMHH(BanListJson DPNHODJHGJL)
		{
			_003CFGIOJMFIIBO_003Ek__BackingField = DPNHODJHGJL;
		}

		[SpecialName]
		public MapsListJson ABDLDNFAKFM()
		{
			return _003CAODPKEOADIP_003Ek__BackingField;
		}

		[SpecialName]
		public void IAKPNEHINJN(FastRanksJson DPNHODJHGJL)
		{
			_003COBHCFKCBFIE_003Ek__BackingField = DPNHODJHGJL;
		}
	}

	[CompilerGenerated]
	private sealed class EGNLMILBMMC
	{
		internal ulong JMMILEFMACB;

		internal bool LJDLIIIPIIJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool INGAIIGAIJC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool KGOFMGFIEBO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool KGKMOLCPDIH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KMIAINALJFJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HBLCHCIHENO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DMKALNCPIAJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JLAJGEPNAJO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DKGPCPBNDPK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool EAPKJLONHBG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool NBFOKGGNEOJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LLELFPJGDBO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FPBODMOMNPG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool OFHCGKJFGDI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PAHEEBJDAEA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PMPBFHNELAJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool DFEBIECLKEK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HGOHMNAGGKI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FPHPIHOGLHK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool OODLIEKJILO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool FJDBPPKABJE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FDEJOKJDJAK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool MJHMNKHNMHF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GEPBCIIDMBC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FGBHLKOCGNE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EIKNIKMNIMO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool NGFGLJGABCM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool AHBIANHNBBC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JFAHEIFLBMA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool ENINHNANGPG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool DPFLLMAOIHH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool LMMBGDBJCJK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LHGKFAAMKFK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PHDFIAGENEE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool BFNOHOLLLHB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool MFEPLHJLMOD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool INCKLCFEMJK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool MOJCLHBKMHF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool CHBEFOHEEGK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool BNAGFAENIDL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PAAEHHJGPCH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool ECGDAHDOPBO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool GDPOLEHICGE(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DKEIJAGNCIJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool DGDAPLBAEFF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BIDLFEPEAEC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HKLBHBIENLO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OMBHIBNMFNB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OFLNMEFFGEM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool CBHLHPPBCIG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool GLLCFMBPDEG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool HMMBBDJNGGL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OLIGLEMPFOP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LCHEOILHFIF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KDDPLGEFPEJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HIKCHCCKLJG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool PJHGLPBPGFG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PHFMMNELDEA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool DGCJLJMCNGH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BJMAIJDIKCN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BOPKCHEPEEB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool IDDDJNEFHJM(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BBGLDGIIDPA(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LHONOMOAHJD(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool IACBEPMAJPH(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool IPPEMIOOKJK(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool JBCHBMKPDAJ(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FBGMHPEEIFC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool DBHMMIKIBIO(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool PGJLKLKAADB(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool LGAPDFABLAN(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool JIMIGOHADJG(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool LHDKMBKLNPL(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool IOFEHEDBMIP(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HKCAPINMNFF(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}

		internal bool NEIDGMKKCBI(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AGJKEBOPIOC(Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB;
		}
	}

	[CompilerGenerated]
	private sealed class OFIPPJELEIA
	{
		internal CSteamID GDOHPDHLPBC;

		internal bool PKAPLCFHDOC(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FJDBPPKABJE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FHFECFLBHMA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool KFNBKFELFLH(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool MGENGAEDACG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JBCHBMKPDAJ(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JKEDCEOCPJO(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FHIJCPPECHA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool IGFOBPKFCDJ(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool DBFPGFHEGKA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JBAJEMGOPDL(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool MAGEPMCPGOC(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool DNIMHEKGJHB(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BFEABMIFIEE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool HBJFIOJFBHC(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EFAPFFFGOOA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool JDELIMPGFDJ(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool INHOEMCLAAP(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AKDOOLPMPMG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BMAOCLKPNNC(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OMBHIBNMFNB(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EDGAPOPEIJF(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BJMAIJDIKCN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FDAIFOAGDLA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LJDLIIIPIIJ(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BDGDIDPDBHG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool PIJAOCFAPKC(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AGFDCBCBAGI(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OFHCGKJFGDI(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool GBKBDKHPLKG(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EKHOOPGPPGE(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OFLDIMDDLHM(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool EGKGJJGAPMN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BEBAENEJFLD(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool OLIGLEMPFOP(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AEIFJLBBKBP(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LHHFJBIAHCN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool BKNHHGBPLGH(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FMIHBNPKEEO(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LNDGINDKPFA(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool LOEAMHGMMPK(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AGJKEBOPIOC(Ban IACGDFHKCAE)
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

		internal bool LLNDDFGPOPL(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FFEGPHJKMFK(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool MEMPOPNAEDN(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool KGKMOLCPDIH(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool FCAGEDLBBHD(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool AEINPAGJFME(Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC;
		}

		internal bool DKGPCPBNDPK(Ban IACGDFHKCAE)
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

	public void GFOOEDJLKPF()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("Failed to 'network-remove' GameObject because it's null.", 0) == 0)
		{
			StartCoroutine(HABBEOOPKJI());
		}
		isRankChanged = true;
	}

	public void ReloadServerInfo(bool HOCAOEIDOEL)
	{
		StartCoroutine(PEPBPLCDPEH(HOCAOEIDOEL));
	}

	public static Dictionary<CSteamID, PlayersRank> GetRanksList()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	public IEnumerator MGPMNKJDGAC(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
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

	public static void CMCPNGECGGA(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].MBKCAGCFALG(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	public static List<PlayerTip> JILOBKNNEPI()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	private IEnumerator IIMBGAIPCLM()
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

	public static List<Map> JBJDLHKLEMN()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	private IEnumerator PIJNOLJOMCD(bool HOCAOEIDOEL = false)
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

	public void ViewAllRanks()
	{
		CloseRanksChanges();
		StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer());
	}

	public void OMKCBLKAKOL()
	{
		StartCoroutine(PEPBPLCDPEH());
	}

	public void CKLHHPBMNBC()
	{
		if (GameManager.LHMIJFLLKHK() && Singleton<SaveSystem>.Instance.HHBIEPMBICO("set", 1) == 0)
		{
			StartCoroutine(HKGHNAABHCB());
		}
		isRankChanged = true;
	}

	public static Dictionary<CSteamID, PlayersRank> GMHKJNIANFA()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	public void AHPIEKAGNJI(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		object[] array = new object[3];
		array[0] = "_Value2";
		array[0] = KKPILMGBPMD;
		array[0] = "Set Sun Input";
		array[1] = BMAEINMDAFF;
		Debug.Log(string.Concat(array));
	}

	public static PlayersRank GetLoadedRank(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<RanksSystem>.Instance.PJCIDKMPHDD[HFEFHOPOLIK];
		}
		return null;
	}

	public long NJDFINDNCHE(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-7, 0, 1, 0, 0, 0)).TotalSeconds;
	}

	private void ODPODBOGLMI(string[] BDGDDFKKGGA)
	{
		foreach (Map item in JBJDLHKLEMN())
		{
			Debug.Log("RecordButton" + item.MMDJFDPIHLA());
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(item.MMDJFDPIHLA()));
		}
	}

	public void DisplayRanksChanges()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("settings.enablerankingnotifications", 1) == 1)
		{
			StartCoroutine(HABBEOOPKJI());
		}
		isRankChanged = false;
	}

	public void LPPMIMLDFBJ(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		object[] array = new object[2];
		array[1] = "_ProjectToPixelMatrix";
		array[1] = KKPILMGBPMD;
		array[3] = "Set Sun Emission";
		array[2] = BMAEINMDAFF;
		Debug.Log(string.Concat(array));
	}

	public static Color FMECGHKFKBK(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "UseScanLine";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = "[RanksSystem] Ranks updated. Next update: ";
		}
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 158)
			{
				mLPCOMHPPNH = "[MapsData] Found ";
			}
			if (JMICLAEOFNP <= -62)
			{
				mLPCOMHPPNH = "[ItemsHandler] No connection to item server: ";
			}
			if (JMICLAEOFNP <= -68)
			{
				mLPCOMHPPNH = "MenuScene";
			}
			if (JMICLAEOFNP <= 105)
			{
				mLPCOMHPPNH = "BitsData";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public static bool PHHDJOBLEMF(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		if (Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Exists((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB))
		{
			if (!LFCLCNMPCNM)
			{
				return false;
			}
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("_Value2" + JMMILEFMACB);
			if (mapData != null)
			{
				string dDAOMDPAIEP = mapData.fullLevelPath + "IntraSig" + Helpers.levelConfigFileName;
				if (!string.IsNullOrEmpty(Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB).LMDDGHCPDAK()))
				{
					return Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper() == Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB).hash.ToUpper();
				}
				return false;
			}
			return true;
		}
		return false;
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

	private IEnumerator DJCOFGJCNKC(bool HOCAOEIDOEL = false)
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

	public static bool ECFIOECNPOM(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		if (Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Exists((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB))
		{
			if (!LFCLCNMPCNM)
			{
				return true;
			}
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("_Value6" + JMMILEFMACB);
			if (mapData != null)
			{
				string dDAOMDPAIEP = mapData.fullLevelPath + "checkpoint" + Helpers.levelConfigFileName;
				if (!string.IsNullOrEmpty(Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB).hash))
				{
					return Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper() == Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB).LMDDGHCPDAK().ToUpper();
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public static Dictionary<CSteamID, PlayersRank> LKFFKNHLNAI()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
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

	public static void PrintMD5(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("workshop." + JMMILEFMACB);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			Debug.Log("[RanksSystem] Map hash: " + JMMILEFMACB + " - " + Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper());
		}
	}

	private void MIONODPCAFD(string[] BDGDDFKKGGA)
	{
		foreach (Map officialMaps in GetOfficialMapsList())
		{
			Debug.Log("Subscribe: " + officialMaps.id);
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(officialMaps.id));
		}
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

	public void FFBDGOBNNCO()
	{
		isLoaded = true;
		Debug.Log("_ScreenResolution");
		ReloadServerInfo();
	}

	public IEnumerator LDCMJLCEFMD(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
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

	public void OLOMKLADHFJ(bool HOCAOEIDOEL)
	{
		StartCoroutine(PIJNOLJOMCD(HOCAOEIDOEL));
	}

	public new void FAAJAMIGJNK()
	{
		base.Awake();
		DebugCommands.BLCLCEDLJBC().CEMAFHEDCMF("steamid", BOCFNCODCOD, "_Value4", "<b>#");
	}

	public int GetRanksChange()
	{
		return CJDDPDGBLNM;
	}

	public static List<Ban> GetCurrentPlayerBans(CSteamID GDOHPDHLPBC)
	{
		return Singleton<RanksSystem>.Instance.FNNKEJFCOPO.FindAll((Ban IACGDFHKCAE) => IACGDFHKCAE.steamID == (ulong)GDOHPDHLPBC);
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

	public long NHBOHPPIALG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(184, 0, 0, 0, 0, 1)).TotalSeconds;
	}

	public static List<PlayerTip> CHNGPGDKHKN()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	public static Color PAHOJJNCEMN(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "Prints list of commands";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= -71)
			{
			}
			if (JMICLAEOFNP <= -107)
			{
			}
			if (JMICLAEOFNP <= 93)
			{
			}
			if (JMICLAEOFNP <= -18)
			{
				mLPCOMHPPNH = "_Exposure";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public void Init()
	{
		isLoaded = false;
		Debug.Log("[RanksSystem] Init");
		ReloadServerInfo();
	}

	private void BDBHFPGCLNE()
	{
		isRankChanged = true;
		if (GetLoadedRank(SteamUser.GetSteamID()) == null)
		{
			return;
		}
		CJDDPDGBLNM = 0;
		int num = Singleton<SaveSystem>.Instance.HHBIEPMBICO("RespawnAfter", -1);
		if (num == -1)
		{
			isRankChanged = false;
			return;
		}
		CJDDPDGBLNM = GetLoadedRank(SteamUser.GetSteamID()).AKPPHHNEAHG() - num;
		if (CJDDPDGBLNM != 0)
		{
			isRankChanged = true;
		}
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

	public static void HPOCNCMLHKK(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("_TimeX" + JMMILEFMACB);
		if (mapData != null)
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use" + Helpers.levelConfigFileName;
			object[] array = new object[0];
			array[0] = "_TimeX";
			array[1] = JMMILEFMACB;
			array[3] = "System.Int64";
			array[6] = Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper();
			Debug.Log(string.Concat(array));
		}
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

	public static bool MLIKFMPFDCO(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		if (Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Exists((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB))
		{
			if (!LFCLCNMPCNM)
			{
				return false;
			}
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("s" + JMMILEFMACB);
			if (mapData != null)
			{
				string dDAOMDPAIEP = mapData.fullLevelPath + "_Fade" + Helpers.levelConfigFileName;
				if (!string.IsNullOrEmpty(Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB).hash))
				{
					return Helpers.CalculateMD5(dDAOMDPAIEP).ToUpper() == Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find((Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == JMMILEFMACB).hash.ToUpper();
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static Dictionary<CSteamID, PlayersRank> HIFPGGHMPIB()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	public static Color NCJKHNEFEBG(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "_FadeDistance";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = "_Smooth";
		}
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 170)
			{
				mLPCOMHPPNH = "Joystick1Button1";
			}
			if (JMICLAEOFNP <= 121)
			{
				mLPCOMHPPNH = "menu.enableselectormusic";
			}
			if (JMICLAEOFNP <= 10)
			{
				mLPCOMHPPNH = "Waiting to start";
			}
			if (JMICLAEOFNP <= 108)
			{
				mLPCOMHPPNH = "[ResourcesManager] Load image error: ";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	private void BOCFNCODCOD(string[] BDGDDFKKGGA)
	{
		foreach (Map officialMaps in GetOfficialMapsList())
		{
			Debug.Log("deletemap" + officialMaps.MMDJFDPIHLA());
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(officialMaps.id));
		}
	}

	public void MOGEMCGHPDJ()
	{
		HOMOBCHPBBP();
		StartCoroutine(Singleton<RanksViewer>.Instance.PHKIFFJAGCL());
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

	public void ReloadServerInfo()
	{
		StartCoroutine(PEPBPLCDPEH());
	}

	public long NPDPGOGKMCG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-158, 1, 0, 1, 0, 0)).TotalSeconds;
	}

	public void SubmitUserVote(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		Debug.Log("SubmitUserVote:" + KKPILMGBPMD + " - " + BMAEINMDAFF);
	}

	public static Color HBCIKNKBMIP(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "_ScreenResolution";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 45)
			{
			}
			if (JMICLAEOFNP <= 4)
			{
			}
			if (JMICLAEOFNP <= 1)
			{
			}
			if (JMICLAEOFNP <= 45)
			{
				mLPCOMHPPNH = "Fade";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public void OBDOFEHLFOP()
	{
		CloseRanksChanges();
		StartCoroutine(Singleton<RanksViewer>.Instance.NGLEIIHHKCD());
	}

	public static Color ECHOJHBDGML(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "SetEnvSpriteColor";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 112)
			{
			}
			if (JMICLAEOFNP <= -24)
			{
			}
			if (JMICLAEOFNP <= -55)
			{
			}
			if (JMICLAEOFNP <= 93)
			{
				mLPCOMHPPNH = ".sav";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	private IEnumerator HKGHNAABHCB()
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

	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("subscribeall", MIONODPCAFD, "Run a command for data system", "<command>");
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

	public int DFFHGBIILKJ()
	{
		return CJDDPDGBLNM;
	}

	public string GetS()
	{
		return s;
	}

	public static Color FJNEIAJPLDF(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mLPCOMHPPNH = "ConfigVersionSlider";
		if (DCNGFCBFNKJ)
		{
			mLPCOMHPPNH = "history";
		}
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= 57)
			{
				mLPCOMHPPNH = "_Value5";
			}
			if (JMICLAEOFNP <= 87)
			{
				mLPCOMHPPNH = "_WaveIntensity";
			}
			if (JMICLAEOFNP <= 16)
			{
				mLPCOMHPPNH = "_Visualize";
			}
			if (JMICLAEOFNP <= 33)
			{
				mLPCOMHPPNH = "settings.disablestoryboard";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	public static List<PlayerTip> GetTipsList()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	private void OIPBGDGNGCD(string[] BDGDDFKKGGA)
	{
		foreach (Map officialMaps in GetOfficialMapsList())
		{
			Debug.Log("#onrankchangedowntext" + officialMaps.id);
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(officialMaps.MMDJFDPIHLA()));
		}
	}

	public static void GOCFAAGBKDM(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].MBKCAGCFALG(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	public void HOMOBCHPBBP()
	{
		if (!GPNKIEPLHNJ)
		{
			StopCoroutine(HABBEOOPKJI());
			StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(rankUpdateCanvas, true, null, false, 743f, false));
			Singleton<SaveSystem>.Instance.DAAJKCCCICP("anonymous", GetLoadedRank(SteamUser.GetSteamID()).INIGKHLOKCD());
		}
		else
		{
			GPNKIEPLHNJ = true;
		}
	}

	public void ACKNMAOHEAN(bool HOCAOEIDOEL)
	{
		StartCoroutine(PIJNOLJOMCD(HOCAOEIDOEL));
	}

	public static List<Map> GetOfficialMapsList()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	public static Color GHMFMOLPEBD(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "Tab1Content";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= -187)
			{
			}
			if (JMICLAEOFNP <= 24)
			{
			}
			if (JMICLAEOFNP <= 27)
			{
			}
			if (JMICLAEOFNP <= 125)
			{
				mLPCOMHPPNH = "EnableRankingToggle";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}

	public static Color DBNMEFKNNHM(int JMICLAEOFNP)
	{
		string mLPCOMHPPNH = "(\\[ */ *h1 *\\])";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 72)
			{
			}
			if (JMICLAEOFNP <= 97)
			{
			}
			if (JMICLAEOFNP <= 115)
			{
			}
			if (JMICLAEOFNP <= 8)
			{
				mLPCOMHPPNH = ",";
			}
		}
		return Helpers.HexToColor(mLPCOMHPPNH);
	}
}
