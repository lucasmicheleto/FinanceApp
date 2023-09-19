﻿using System;
namespace AppFinance.Models
{
	public class Transaction
	{
		public int Id { get; set; }
		public TransactionType Type { get; set; }
		public string Name { get; set; }
		public DateTimeOffset Date { get; set; }
		public decimal Value { get; set; }
	}

	public enum TransactionType
	{
		Income,
		Expense
	}
}

