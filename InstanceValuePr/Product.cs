namespace MyApp
{
    class Product
    {
        public static string origin = "대한민국";
        public string name = "구황작물";
        public int price = 1000;

        // C#은 메서드를 오버라이딩하면 필수적으로 써줘야 함
        public override string ToString()
        {
            return "이름 : " + this.name + " / 가격 : " + this.price;
        }
    }
}