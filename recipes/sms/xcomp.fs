( 8K of onboard RAM )
0xc000 CONSTANT RAMSTART
0xdd00 CONSTANT RS_ADDR
( Memory register at the end of RAM. Must not overwrite )
0xddca CONSTANT PS_ADDR
0xbf   CONSTANT VDP_CTLPORT
0xbe   CONSTANT VDP_DATAPORT
32     CONSTANT VDP_COLS
24     CONSTANT VDP_ROWS
212 LOAD  ( z80 assembler )
: ZFILL, ( u ) 0 DO 0 A, LOOP ;
262 LOAD  ( xcomp )
524 LOAD  ( font compiler )
270 LOAD  ( xcomp overrides )

0x100 JPnn, 0x63 ZFILL, ( 0x66 )
RETN, 0x98 ZFILL, ( 0x100 )
( All set, carry on! )
CURRENT @ XCURRENT !
0x100 BIN( !
282 LOAD  ( boot.z80 )
393 LOAD  ( xcomp core low )
CREATE ~FNT CPFNT7x7
623 628 LOADR ( VDP )
: (key) 4 ;
420 LOAD  ( xcomp core high )
(entry) _
( Update LATEST )
PC ORG @ 8 + !
," VDP$ " EOT,
ORG @ 0x100 - 256 /MOD 2 PC! 2 PC!
H@ 256 /MOD 2 PC! 2 PC!