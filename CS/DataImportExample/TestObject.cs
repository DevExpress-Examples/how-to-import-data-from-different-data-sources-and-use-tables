namespace DataImportExample
{
    #region #testObject
    class TestObject
    {
        public TestObject(int intValue, string value, bool boolValue, byte[] imageValue)
        {
            this.intValue = intValue;
            this.Value = value;
            this.BoolValue = boolValue;
            this.ImageValue = imageValue;

        }

        public TestObject(int intValue, string value, bool boolValue, string imageBase64)
        {
            this.intValue = intValue;
            this.Value = value;
            this.BoolValue = boolValue;
            this.ImageBase64 = imageBase64;
        }
        public int intValue;
        private int privateValue { get { return 123; } }
        public int IntValue { get { return intValue + privateValue - 123; } }
        public string Value { get; set; }
        public bool BoolValue { get; set; }
        public byte[] ImageValue { get; set; }
        public int this[int index] { get { return index; } }
        public string ImageBase64 { get; set; }

    }
    #endregion #testObject
}
