Promos/MainWindow.xaml.cs 
@@ -33,8 +33,6 @@ public MainWindow()
            InitializeComponent();

            payment = new Payment(this);
            payment.setBalance(500000);
            payment.setPromo(0);

            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(payment, this);

@@ -49,9 +47,9 @@ public MainWindow()

        private void initializeView()
        {
            labelSubtotal.Content = 0;
            labelGrantTotal.Content = 0;
            labelPromoFee.Content = (payment.getPromo() > 0) ? - payment.getPromo() : 0;
            labelSubtotal.Content = "Rp 0";
            labelGrantTotal.Content = "Rp 0";
            labelPromoFee.Content = "Rp 0";
        }

        public void onPenawaranSelected(Item item)