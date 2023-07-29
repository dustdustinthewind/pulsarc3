// NewsTile
using UnityEngine;
using UnityEngine.UI;

public class NewsTile : MonoBehaviour
{
	public Text nameText;

	public Text descriptionText;

	public Image image;

	public Image splashImage;

	public Slider newsIDSlider;

	private string IEAEOKEAJMA;

	private void CFIAKIJAILI()
	{
	}

	public void FHPNIFPJKCK()
	{
		Singleton<GameManager>.Instance.OpenURL(IEAEOKEAJMA);
	}

	public void NMOMMMPKMEL()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(IEAEOKEAJMA);
	}

	public void NJNKMDAGPAN(float JMMILEFMACB)
	{
	}

	public void ILHHAJMENLA(float JMMILEFMACB)
	{
	}

	public void EGNNIHHGOAF(float JMMILEFMACB)
	{
	}

	private void Update()
	{
	}

	private void KMKLDAJLCNM()
	{
	}

	public void NBHPMNKIHDP(float JMMILEFMACB)
	{
	}

	public void EPDCHKECMBL(string IOHIHHEBPDK, string ADLFGFFKELL, Sprite BBFDELDIDOG, string IEAEOKEAJMA)
	{
		nameText.text = IOHIHHEBPDK;
		descriptionText.text = ADLFGFFKELL;
		if ((bool)BBFDELDIDOG)
		{
			image.sprite = BBFDELDIDOG;
			image.GetComponent<AspectRatioFitter>().aspectRatio = (float)BBFDELDIDOG.texture.width / (float)BBFDELDIDOG.texture.height;
		}
		this.IEAEOKEAJMA = IEAEOKEAJMA;
	}

	private void JOACBIEHHCE()
	{
	}

	public void SwichNews(float JMMILEFMACB)
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	public void LHBFGFMJIJB(float JMMILEFMACB)
	{
	}

	private void GHILDCBCDJI()
	{
	}

	public void AKEIPNLIHNL()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(IEAEOKEAJMA);
	}

	public void HHAECEMFKND()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(IEAEOKEAJMA);
	}

	private void OCMKCBBCEFG()
	{
	}

	public void ALKBNPMCEOM(string IOHIHHEBPDK, string ADLFGFFKELL, Sprite BBFDELDIDOG, string IEAEOKEAJMA)
	{
		nameText.text = IOHIHHEBPDK;
		descriptionText.text = ADLFGFFKELL;
		if ((bool)BBFDELDIDOG)
		{
			image.sprite = BBFDELDIDOG;
			image.GetComponent<AspectRatioFitter>().aspectRatio = (float)BBFDELDIDOG.texture.width / (float)BBFDELDIDOG.texture.height;
		}
		this.IEAEOKEAJMA = IEAEOKEAJMA;
	}

	public void OnClick()
	{
		Singleton<GameManager>.Instance.OpenURL(IEAEOKEAJMA);
	}

	public void Init(string IOHIHHEBPDK, string ADLFGFFKELL, Sprite BBFDELDIDOG, string IEAEOKEAJMA)
	{
		nameText.text = IOHIHHEBPDK;
		descriptionText.text = ADLFGFFKELL;
		if ((bool)BBFDELDIDOG)
		{
			image.sprite = BBFDELDIDOG;
			image.GetComponent<AspectRatioFitter>().aspectRatio = (float)BBFDELDIDOG.texture.width / (float)BBFDELDIDOG.texture.height;
		}
		this.IEAEOKEAJMA = IEAEOKEAJMA;
	}

	private void AGMJDGHLBMN()
	{
	}
}
