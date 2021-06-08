using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Nethereum.Web3;

public class CheckBalance : MonoBehaviour
{
    private void OnMouseDown()
    {
        async void Start()
        {
            string network = "ropsten";
            Ethereum ethereum = new Ethereum(network);
            string account = "0x09cBe6289fb380DCEB33E43F6Ab3c51D96bE709b";
            BigInteger wei = await ethereum.balanceOf(account);
            print("wei: " + wei);
            print("eth: " + Web3.Convert.FromWei(wei));
        }
    }
}
