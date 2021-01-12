Promos/Model/Payment.cs 
@@ -15,33 +15,12 @@ public Payment(OnPaymentChangedListener paymentCallback)
            this.paymentCallback = paymentCallback;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public double getPromo()
        {
            return this.promo;
        }

        public void setPromo(double promo)
        {
            this.promo = promo;
        }

        public void updateTotal(double subtotal, double potongan)
        {
            double total = subtotal + potongan;
            this.paymentCallback.onPriceUpdated(subtotal,  total, potongan);
        }


    }

    interface OnPaymentChangedListener