// ImageLoader
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoader : MonoBehaviour
{
	public FileSelector selector;

	public Image img;

	public void EJKDBAAENJA()
	{
		StartCoroutine(DMJJDOBMMEK(selector.result));
	}

	public void GNKMOCJAPHG()
	{
		StartCoroutine(GPCEPAFHDNO(selector.result));
	}

	public void IBJCADPGODA()
	{
		StartCoroutine(LoadImage(selector.result));
	}

	public IEnumerator NMFGPCDBHBJ(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void HOMCJCILNKN()
	{
		StartCoroutine(NMFGPCDBHBJ(selector.result));
	}

	public IEnumerator GPCEPAFHDNO(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator ABBBLKAHIGE(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void NKLJNCJDAJP()
	{
		StartCoroutine(APCMEBGEDGM(selector.result));
	}

	public void FIJHIHOIMFJ()
	{
		StartCoroutine(BFGJBKIMOOO(selector.result));
	}

	public IEnumerator CKAKDGBMEGP(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator DCJLBJBHNDM(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator MCHDADCLBCP(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void APGAGALMNIC()
	{
		StartCoroutine(DCJLBJBHNDM(selector.result));
	}

	public void OOMMLOGMOKH()
	{
		StartCoroutine(DCJLBJBHNDM(selector.result));
	}

	public void KMNIGEKAMFP()
	{
		StartCoroutine(DMJJDOBMMEK(selector.result));
	}

	public void BJDKMLEONEA()
	{
		StartCoroutine(MCHDADCLBCP(selector.result));
	}

	public IEnumerator BBMNDCFADJI(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void NNJOCAEMPPK()
	{
		StartCoroutine(OGGGNDODCBK(selector.result));
	}

	public void OnLoadClick()
	{
		StartCoroutine(LoadImage(selector.result));
	}

	public IEnumerator FOPMJJCOPCN(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator DMJJDOBMMEK(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void BECHKBKDFMJ()
	{
		StartCoroutine(DCJLBJBHNDM(selector.result));
	}

	public void PADHKCFMNEL()
	{
		StartCoroutine(DMJJDOBMMEK(selector.result));
	}

	public IEnumerator IHMDPKFAIII(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void PDIAEGLMNDN()
	{
		StartCoroutine(OGGGNDODCBK(selector.result));
	}

	public IEnumerator LoadImage(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator AGAENECADEM(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void DGDCAAKIDOB()
	{
		StartCoroutine(BFGJBKIMOOO(selector.result));
	}

	public IEnumerator HCCPMFLOJEH(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator OGGGNDODCBK(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void DJNHGBIEPGH()
	{
		StartCoroutine(LoadImage(selector.result));
	}

	public void ICJPCMGICFO()
	{
		StartCoroutine(IHMDPKFAIII(selector.result));
	}

	public IEnumerator APCMEBGEDGM(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void LNBBCLBHICH()
	{
		StartCoroutine(POLFAMGIMLD(selector.result));
	}

	public IEnumerator POLFAMGIMLD(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public IEnumerator BFGJBKIMOOO(string BNJFKKGOACF)
	{
		WWW wWW = new WWW("file://" + BNJFKKGOACF);
		yield return wWW;
		Texture2D texture = wWW.texture;
		Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100f);
		yield return sprite;
		img.sprite = sprite;
		Debug.Log("[ImageLoader] Loaded image from " + BNJFKKGOACF);
	}

	public void NCHCLJEONCJ()
	{
		StartCoroutine(OGGGNDODCBK(selector.result));
	}

	public void PICIBLAHJME()
	{
		StartCoroutine(DMJJDOBMMEK(selector.result));
	}
}
