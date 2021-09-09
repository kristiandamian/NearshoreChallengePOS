﻿namespace CoE_Challenge.Products
{
	public class Nachos : IProduct
    {
        public string Name { get; } = "Nachos";
        public float Price { get; set; } = 7;
		public bool IsSnack { get; } = true;
		public bool IsDiscount { get; } = false;
    }
}
