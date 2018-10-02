using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_pamoka_ND
{
    class BankAccount
    {
    	private int AccountNumber;
    	private string UserName;
    	private float Balance;
    	private string Currency;
    	private List<string> History = new List<string>();
    	private int TransactionNumber;
    	
    	public BankAccount (int number, string user, string currency = "EUR")
    	{
    		AccountNumber = number;
    		UserName = user;
    		Balance =0;
    		Currency = currency;
    		TransactionNumber = 0;
    		History.Add("Transaction number: "+TransactionNumber+ " Account created " + DateTime.Now);
    		
    		
    	}
    	public List<string> GetHistory ()
    	{
    		return History;
    	}
    	public void PrintHistory ()
    	{
    		foreach (string item in History)
    		{
    			Console.WriteLine(item);
    		}
    	}
    	public void AddMoney(float value)
    	{
    		Balance +=value;
    		TransactionNumber++;
    		History.Add("Transaction number: "+TransactionNumber+ " Received +"+value+" "+Currency);
    	}
    	public void GetMoney(float value)
    	{
    		Balance -=value;
    		TransactionNumber++;
    		History.Add("Transaction number: "+TransactionNumber+ "Received +"+value+" "+Currency);
    	}
    	public float GetBalance()
    	{
    		return Balance;
    	}
    	
    	
        

    }
}
