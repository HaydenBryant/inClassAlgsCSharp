int firstDuplicate(int[] a) {
    
    var valuesArray = new int[a.Length];
    
    for(var i = 0; i < a.Length; i++)
    {        
        if(Array.Exists(valuesArray, number => number == a[i]))
        {
            return a[i];
        }
        
        valuesArray[i] = a[i];
    }
    
    return -1;
}