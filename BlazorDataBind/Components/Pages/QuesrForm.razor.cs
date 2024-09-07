namespace BlazorDataBind.Components.Pages
{
    public partial class QuesrForm
    {
        public string name { get; set; }
        public int age { get; set; }


        // select
        public int prefecture { get; set; } 
        public Dictionary<string, int> prefectureDic { get; set; } = new();


        // checkbox, 数が多い場合は配列対応もあり
        public bool likeCSharp { get; set; }
        public bool likeVB{ get; set; }

        public string Message { get; set; } 

        protected override void OnInitialized()
        {
            prefectureDic.Add("北海道", 0);
            prefectureDic.Add("東京", 1);
            prefectureDic.Add("沖縄", 2);

            // init
            name = "名無し";
            age = 20;
            prefecture = 1;
        }

        private void onSubmit()
        {
            Message = "登録成功";
        }

    }
}
