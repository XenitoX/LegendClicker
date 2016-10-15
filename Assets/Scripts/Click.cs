using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Click : MonoBehaviour {

	public Text DisplayCoins;
	public Text DisplayPotatoes;
	public Text DisplaySellFor;

	public float clickPower;
	public float Coins;
	public float currPotatoes;
	public float sellPrice;

	private string SellPriceGoodBoi;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(sellPrice <= 1){
			SellPriceGoodBoi = "Coin";
		}else{
			SellPriceGoodBoi = "Coins";
		}

		DisplayPotatoes.text = "Potatoes: " + currPotatoes;
		DisplayCoins.text = "Coins: " + Coins;
		DisplaySellFor.text = "Sell each potato for: " + sellPrice + " " + SellPriceGoodBoi;

	}


	public void Clicked(){

		currPotatoes += clickPower;

	}
	public void SellPotatoes(){
		Coins += (currPotatoes * sellPrice);
		currPotatoes = 0;
	
	}
}
