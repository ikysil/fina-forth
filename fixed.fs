: fxdivider 1 dpl @ 0 max 0 ?do 10 * loop ;
: >fx ( d -- fx ) dup 0< <> -11 and throw  65536 fxdivider */ ;
: fx# parse-word s>dnumber >fx state @ if postpone literal then ; immediate 