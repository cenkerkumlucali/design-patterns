class ProductCreator
{
    static public IProduct GetInstance(ProductType productType)
    {
        IProduct _product = null;
        switch (productType)
        {
            case ProductType.A:
                _product = new A();
                //....
                break;
            case ProductType.B:
                _product = new B();
                //...
                break;
            case ProductType.C:
                _product = new C();
                break;
        }
        return _product;
    }
}