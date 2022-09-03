int a1 = 198;
int b1 = 1;
int c1 = 24;
int a2 = 234;
int b2 = 32;
int c2 = 33;
int a3 = 49;
int b3 = 12;
int c3 = 1541;
int max = a1;

if(b1 > max) max = b1;
if(c1 > max) max = b1;

if(a2 > max) max = a1;
if(b2 > max) max = b2;

if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);