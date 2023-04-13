using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio
{

    public class entidad_raiz
    {
        public Entities entities { get; set; }
    }

    public class Entities
    {
        public Q5682 Q5682 { get; set; }
    }

    public class Q5682
    {
        public int pageid { get; set; }
        public int ns { get; set; }
        public string title { get; set; }
        public int lastrevid { get; set; }
        public DateTime modified { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Labels labels { get; set; }
        public Descriptions descriptions { get; set; }
        public Aliases aliases { get; set; }
        public Claims claims { get; set; }
        public Sitelinks sitelinks { get; set; }
    }

    public class Labels
    {
        public En en { get; set; }
        public Fr fr { get; set; }
        public De de { get; set; }
        public It it { get; set; }
        public Ilo ilo { get; set; }
        public BeTarask betarask { get; set; }
        public Kk kk { get; set; }
        public EnCa enca { get; set; }
        public EnGb engb { get; set; }
        public Af af { get; set; }
        public Gsw gsw { get; set; }
        public An an { get; set; }
        public Ar ar { get; set; }
        public Arz arz { get; set; }
        public Ast ast { get; set; }
        public Ay ay { get; set; }
        public Az az { get; set; }
        public Bcl bcl { get; set; }
        public Be be { get; set; }
        public Bg bg { get; set; }
        public Bn bn { get; set; }
        public Br br { get; set; }
        public Bs bs { get; set; }
        public Ca ca { get; set; }
        public Ckb ckb { get; set; }
        public Co co { get; set; }
        public Cs cs { get; set; }
        public Cy cy { get; set; }
        public Da da { get; set; }
        public Diq diq { get; set; }
        public El el { get; set; }
        public Eo eo { get; set; }
        public Es es { get; set; }
        public Et et { get; set; }
        public Eu eu { get; set; }
        public Ext ext { get; set; }
        public Fa fa { get; set; }
        public Fi fi { get; set; }
        public Fy fy { get; set; }
        public Ga ga { get; set; }
        public Gan gan { get; set; }
        public Gd gd { get; set; }
        public Gl gl { get; set; }
        public He he { get; set; }
        public Hif hif { get; set; }
        public Hr hr { get; set; }
        public Hu hu { get; set; }
        public Hy hy { get; set; }
        public Ia ia { get; set; }
        public Id id { get; set; }
        public Ie ie { get; set; }
        public Io io { get; set; }
        public Is _is { get; set; }
        public Ja ja { get; set; }
        public Ka ka { get; set; }
        public Kaa kaa { get; set; }
        public Kab kab { get; set; }
        public Ko ko { get; set; }
        public La la { get; set; }
        public Lb lb { get; set; }
        public Lmo lmo { get; set; }
        public Lt lt { get; set; }
        public Lv lv { get; set; }
        public Mhr mhr { get; set; }
        public Mk mk { get; set; }
        public Ml ml { get; set; }
        public Mn mn { get; set; }
        public Mr mr { get; set; }
        public Mrj mrj { get; set; }
        public Ms ms { get; set; }
        public Mt mt { get; set; }
        public Mwl mwl { get; set; }
        public My my { get; set; }
        public Nah nah { get; set; }
        public Nds nds { get; set; }
        public New _new { get; set; }
        public Nl nl { get; set; }
        public Nn nn { get; set; }
        public Oc oc { get; set; }
        public Os os { get; set; }
        public Pag pag { get; set; }
        public Pam pam { get; set; }
        public Pl pl { get; set; }
        public Pms pms { get; set; }
        public Pnb pnb { get; set; }
        public Pt pt { get; set; }
        public PtBr ptbr { get; set; }
        public Qu qu { get; set; }
        public Ro ro { get; set; }
        public Ru ru { get; set; }
        public Rue rue { get; set; }
        public Sah sah { get; set; }
        public Sc sc { get; set; }
        public Scn scn { get; set; }
        public Sh sh { get; set; }
        public Sk sk { get; set; }
        public Sl sl { get; set; }
        public Sq sq { get; set; }
        public Sr sr { get; set; }
        public Sv sv { get; set; }
        public Sw sw { get; set; }
        public Ta ta { get; set; }
        public Tg tg { get; set; }
        public Th th { get; set; }
        public Tl tl { get; set; }
        public Tr tr { get; set; }
        public Tt tt { get; set; }
        public Uk uk { get; set; }
        public Ur ur { get; set; }
        public Uz uz { get; set; }
        public Vec vec { get; set; }
        public Vep vep { get; set; }
        public Vi vi { get; set; }
        public Vo vo { get; set; }
        public War war { get; set; }
        public Xmf xmf { get; set; }
        public Yi yi { get; set; }
        public Yo yo { get; set; }
        public Za za { get; set; }
        public Zh zh { get; set; }
        public Yue yue { get; set; }
        public Ba ba { get; set; }
        public Min min { get; set; }
        public Bxr bxr { get; set; }
        public Pa pa { get; set; }
        public Ku ku { get; set; }
        public Li li { get; set; }
        public Mzn mzn { get; set; }
        public Ce ce { get; set; }
        public Tk tk { get; set; }
        public Kbd kbd { get; set; }
        public Ab ab { get; set; }
        public Nb nb { get; set; }
        public DeCh dech { get; set; }
        public Mg mg { get; set; }
        public CrhLatn crhlatn { get; set; }
        public Sgs sgs { get; set; }
        public Nan nan { get; set; }
        public Vro vro { get; set; }
        public Sco sco { get; set; }
        public Gn gn { get; set; }
        public Nov nov { get; set; }
        public Bar bar { get; set; }
        public Rup rup { get; set; }
        public Am am { get; set; }
        public Na na { get; set; }
        public Kw kw { get; set; }
        public Pcd pcd { get; set; }
        public Jv jv { get; set; }
        public Wuu wuu { get; set; }
        public Jam jam { get; set; }
        public Ti ti { get; set; }
        public Bho bho { get; set; }
        public Bi bi { get; set; }
        public Kbp kbp { get; set; }
        public CbkZam cbkzam { get; set; }
        public Ceb ceb { get; set; }
        public Azb azb { get; set; }
        public Fo fo { get; set; }
        public Crh crh { get; set; }
        public Lfn lfn { get; set; }
        public Myv myv { get; set; }
        public Ky ky { get; set; }
        public Frr frr { get; set; }
        public Sat sat { get; set; }
        public Lzh lzh { get; set; }
        public Jbo jbo { get; set; }
        public Lad lad { get; set; }
        public Gcr gcr { get; set; }
        public Arc arc { get; set; }
        public Avk avk { get; set; }
        public Lld lld { get; set; }
        public Ary ary { get; set; }
        public Frp frp { get; set; }
        public Pap pap { get; set; }
        public Av av { get; set; }
        public Tum tum { get; set; }
        public Kcg kcg { get; set; }
        public DeAt deat { get; set; }
        public Sje sje { get; set; }
        public Jut jut { get; set; }
        public Hyw hyw { get; set; }
        public Ha ha { get; set; }
    }

    public class En
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class De
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class It
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ilo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class BeTarask
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class EnCa
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class EnGb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Af
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gsw
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class An
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ar
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Arz
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ast
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ay
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Az
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bcl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Be
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bg
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Br
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bs
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ca
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ckb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Co
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Cs
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Cy
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Da
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Diq
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class El
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Eo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Es
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Et
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Eu
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ext
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fa
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fi
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fy
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ga
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gan
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gd
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class He
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hif
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hu
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hy
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ia
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Id
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ie
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Io
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Is
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ja
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ka
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kaa
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kab
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ko
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class La
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lmo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lt
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lv
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mhr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ml
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mrj
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ms
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mt
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mwl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class My
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nah
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nds
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class New
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Oc
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Os
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pag
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pam
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pms
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pnb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pt
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class PtBr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Qu
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ro
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ru
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Rue
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sah
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sc
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Scn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sh
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sq
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sv
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sw
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ta
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tg
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Th
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tl
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tt
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Uk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ur
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Uz
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vec
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vep
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vi
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class War
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Xmf
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Yi
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Yo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Za
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Zh
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Yue
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ba
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Min
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bxr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pa
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ku
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Li
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mzn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ce
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kbd
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ab
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class DeCh
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mg
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class CrhLatn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sgs
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nan
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vro
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sco
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nov
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bar
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Rup
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Am
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Na
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kw
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pcd
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Jv
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Wuu
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Jam
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ti
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bho
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bi
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kbp
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class CbkZam
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ceb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Azb
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Crh
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lfn
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Myv
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ky
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Frr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sat
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lzh
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Jbo
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lad
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gcr
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Arc
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Avk
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lld
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ary
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Frp
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pap
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Av
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tum
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kcg
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class DeAt
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sje
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Jut
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hyw
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ha
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Descriptions
    {
        public De1 de { get; set; }
        public It1 it { get; set; }
        public Ilo1 ilo { get; set; }
        public Es1 es { get; set; }
        public Fr1 fr { get; set; }
        public Lv1 lv { get; set; }
        public Pl1 pl { get; set; }
        public Ru1 ru { get; set; }
        public En1 en { get; set; }
        public Gl1 gl { get; set; }
        public Pam1 pam { get; set; }
        public Ast1 ast { get; set; }
        public Cs1 cs { get; set; }
        public Sl1 sl { get; set; }
        public Ne ne { get; set; }
        public Nl1 nl { get; set; }
        public Ca1 ca { get; set; }
        public El1 el { get; set; }
        public Eu1 eu { get; set; }
        public Eo1 eo { get; set; }
        public He1 he { get; set; }
        public Sk1 sk { get; set; }
        public Sq1 sq { get; set; }
        public Bg1 bg { get; set; }
        public Fi1 fi { get; set; }
        public Sv1 sv { get; set; }
        public Id1 id { get; set; }
        public Ro1 ro { get; set; }
        public Tr1 tr { get; set; }
        public Uk1 uk { get; set; }
        public Ja1 ja { get; set; }
        public Bs1 bs { get; set; }
        public Nb1 nb { get; set; }
        public Pap1 pap { get; set; }
        public Dv dv { get; set; }
        public Vi1 vi { get; set; }
        public Ga1 ga { get; set; }
        public Hu1 hu { get; set; }
    }

    public class De1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class It1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ilo1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Es1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fr1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lv1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pl1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ru1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class En1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gl1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pam1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ast1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Cs1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sl1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ne
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nl1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ca1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class El1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Eu1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Eo1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class He1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sk1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sq1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bg1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fi1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sv1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Id1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ro1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tr1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Uk1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ja1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bs1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nb1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pap1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Dv
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vi1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ga1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hu1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Aliases
    {
        public It2[] it { get; set; }
        public BeTarask1[] betarask { get; set; }
        public Kk1[] kk { get; set; }
        public E[] es { get; set; }
        public Ar1[] ar { get; set; }
        public Zh1[] zh { get; set; }
        public Fa1[] fa { get; set; }
        public Ja2[] ja { get; set; }
        public He2[] he { get; set; }
        public Ru2[] ru { get; set; }
        public En2[] en { get; set; }
        public Gl2[] gl { get; set; }
        public Ast2[] ast { get; set; }
        public C[] cs { get; set; }
        public Sl2[] sl { get; set; }
        public El2[] el { get; set; }
        public Eo2[] eo { get; set; }
        public Th1[] th { get; set; }
        public Ky1[] ky { get; set; }
        public Ro2[] ro { get; set; }
        public De2[] de { get; set; }
        public Fr2[] fr { get; set; }
        public Bar1[] bar { get; set; }
        public Az1[] az { get; set; }
        public Ba1[] ba { get; set; }
        public Bcl1[] bcl { get; set; }
        public Bxr1[] bxr { get; set; }
        public Ca2[] ca { get; set; }
        public Ceb1[] ceb { get; set; }
        public Crh1[] crh { get; set; }
        public Diq1[] diq { get; set; }
        public Gd1[] gd { get; set; }
        public Hr1[] hr { get; set; }
        public Jbo1[] jbo { get; set; }
        public Kab1[] kab { get; set; }
        public La1[] la { get; set; }
        public Lt1[] lt { get; set; }
        public Lv2[] lv { get; set; }
        public Mrj1[] mrj { get; set; }
        public Myv1[] myv { get; set; }
        public My1[] my { get; set; }
        public Nd[] nds { get; set; }
        public Nn1[] nn { get; set; }
        public Pa1[] pa { get; set; }
        public Sv2[] sv { get; set; }
        public Tk1[] tk { get; set; }
        public Ur1[] ur { get; set; }
        public Za1[] za { get; set; }
        public CrhLatn1[] crhlatn { get; set; }
        public Vro1[] vro { get; set; }
        public Yi1[] yi { get; set; }
        public Pt1[] pt { get; set; }
        public Fi2[] fi { get; set; }
        public Nl2[] nl { get; set; }
        public Ext1[] ext { get; set; }
        public Et1[] et { get; set; }
        public Hu2[] hu { get; set; }
        public Fy1[] fy { get; set; }
        public Kw1[] kw { get; set; }
        public M[] ms { get; set; }
        public Ku1[] ku { get; set; }
        public B[] bs { get; set; }
        public Oc1[] oc { get; set; }
        public Pl2[] pl { get; set; }
        public Ia1[] ia { get; set; }
        public Vi2[] vi { get; set; }
        public Id2[] id { get; set; }
        public Tr2[] tr { get; set; }
        public Da1[] da { get; set; }
        public Af1[] af { get; set; }
        public Br1[] br { get; set; }
        public Sg[] sgs { get; set; }
        public Lld1[] lld { get; set; }
    }

    public class It2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class BeTarask1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kk1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class E
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ar1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Zh1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fa1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ja2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class He2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ru2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class En2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gl2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ast2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class C
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sl2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class El2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Eo2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Th1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ky1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ro2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class De2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fr2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bar1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Az1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ba1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bcl1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Bxr1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ca2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ceb1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Crh1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Diq1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Gd1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hr1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Jbo1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kab1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class La1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lt1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lv2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Mrj1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Myv1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class My1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nd
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nn1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pa1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sv2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tk1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ur1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Za1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class CrhLatn1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vro1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Yi1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pt1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fi2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Nl2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ext1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Et1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Hu2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Fy1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Kw1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class M
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ku1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class B
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Oc1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Pl2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Ia1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Vi2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Id2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Tr2
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Da1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Af1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Br1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Sg
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Lld1
    {
        public string language { get; set; }
        public string value { get; set; }
    }

    public class Claims
    {
        public P103[] P103 { get; set; }
        public P27[] P27 { get; set; }
        public P106[] P106 { get; set; }
        public P214[] P214 { get; set; }
        public P244[] P244 { get; set; }
        public P227[] P227 { get; set; }
        public P213[] P213 { get; set; }
        public P434[] P434 { get; set; }
        public P373[] P373 { get; set; }
        public P20[] P20 { get; set; }
        public P569[] P569 { get; set; }
        public P570[] P570 { get; set; }
        public P691[] P691 { get; set; }
        public P910[] P910 { get; set; }
        public P268[] P268 { get; set; }
        public P947[] P947 { get; set; }
        public P349[] P349 { get; set; }
        public P269[] P269 { get; set; }
        public P31[] P31 { get; set; }
        public P646[] P646 { get; set; }
        public P109[] P109 { get; set; }
        public P1207[] P1207 { get; set; }
        public P1006[] P1006 { get; set; }
        public P950[] P950 { get; set; }
        public P1017[] P1017 { get; set; }
        public P10051[] P1005 { get; set; }
        public P906[] P906 { get; set; }
        public P396[] P396 { get; set; }
        public P735[] P735 { get; set; }
        public P800[] P800 { get; set; }
        public P1273[] P1273 { get; set; }
        public P1430[] P1430 { get; set; }
        public P345[] P345 { get; set; }
        public P1472[] P1472 { get; set; }
        public P866[] P866 { get; set; }
        public P723[] P723 { get; set; }
        public P1636[] P1636 { get; set; }
        public P1015[] P1015 { get; set; }
        public P119[] P119 { get; set; }
        public P1263[] P1263 { get; set; }
        public P1711[] P1711 { get; set; }
        public P1741[] P1741 { get; set; }
        public P1559[] P1559 { get; set; }
        public P1938[] P1938 { get; set; }
        public P19[] P19 { get; set; }
        public P40[] P40 { get; set; }
        public P1266[] P1266 { get; set; }
        public P648[] P648 { get; set; }
        public P1565[] P1565 { get; set; }
        public P2252[] P2252 { get; set; }
        public P1412[] P1412 { get; set; }
        public P1315[] P1315 { get; set; }
        public P136[] P136 { get; set; }
        public P935[] P935 { get; set; }
        public P1343[] P1343 { get; set; }
        public P1871[] P1871 { get; set; }
        public P26[] P26 { get; set; }
        public P2163[] P2163 { get; set; }
        public P2533[] P2533 { get; set; }
        public P1417[] P1417 { get; set; }
        public P1280[] P1280 { get; set; }
        public P1977[] P1977 { get; set; }
        public P2639[] P2639 { get; set; }
        public P12201[] P1220 { get; set; }
        public P2435[] P2435 { get; set; }
        public P2168[] P2168 { get; set; }
        public P2019[] P2019 { get; set; }
        public P2604[] P2604 { get; set; }
        public P2605[] P2605 { get; set; }
        public P1899[] P1899 { get; set; }
        public P409[] P409 { get; set; }
        public P245[] P245 { get; set; }
        public P2799[] P2799 { get; set; }
        public P12961[] P1296 { get; set; }
        public P1196[] P1196 { get; set; }
        public P2188[] P2188 { get; set; }
        public P2469[] P2469 { get; set; }
        public P3348[] P3348 { get; set; }
        public P34301[] P3430 { get; set; }
        public P3417[] P3417 { get; set; }
        public P3762[] P3762 { get; set; }
        public P2949[] P2949 { get; set; }
        public P3788[] P3788 { get; set; }
        public P3932[] P3932 { get; set; }
        public P3964[] P3964 { get; set; }
        public P3965[] P3965 { get; set; }
        public P4145[] P4145 { get; set; }
        public P3782[] P3782 { get; set; }
        public P2886[] P2886 { get; set; }
        public P135[] P135 { get; set; }
        public P3241[] P3241 { get; set; }
        public P4399[] P4399 { get; set; }
        public P1728[] P1728 { get; set; }
        public P3192[] P3192 { get; set; }
        public P1953[] P1953 { get; set; }
        public P4431[] P4431 { get; set; }
        public P734[] P734 { get; set; }
        public P4459[] P4459 { get; set; }
        public P1607[] P1607 { get; set; }
        public P4553[] P4553 { get; set; }
        public P3630[] P3630 { get; set; }
        public P4629[] P4629 { get; set; }
        public P839[] P839 { get; set; }
        public P3154[] P3154 { get; set; }
        public P1828[] P1828 { get; set; }
        public P3219[] P3219 { get; set; }
        public P1950[] P1950 { get; set; }
        public P451[] P451 { get; set; }
        public P1477[] P1477 { get; set; }
        public P1448[] P1448 { get; set; }
        public P22[] P22 { get; set; }
        public P25[] P25 { get; set; }
        public P1670[] P1670 { get; set; }
        public P949[] P949 { get; set; }
        public P5008[] P5008 { get; set; }
        public P5068[] P5068 { get; set; }
        public P51011[] P5101 { get; set; }
        public P12331[] P1233 { get; set; }
        public P69[] P69 { get; set; }
        public P172[] P172 { get; set; }
        public P3987[] P3987 { get; set; }
        public P2924[] P2924 { get; set; }
        public P4802[] P4802 { get; set; }
        public P5361[] P5361 { get; set; }
        public P509[] P509 { get; set; }
        public P140[] P140 { get; set; }
        public P55701[] P5570 { get; set; }
        public P1580[] P1580 { get; set; }
        public P5613[] P5613 { get; set; }
        public P535[] P535 { get; set; }
        public P2977[] P2977 { get; set; }
        public P5731[] P5731 { get; set; }
        public P5587[] P5587 { get; set; }
        public P3222[] P3222 { get; set; }
        public P5951[] P5951 { get; set; }
        public P5491[] P5491 { get; set; }
        public P21[] P21 { get; set; }
        public P6173[] P6173 { get; set; }
        public P5905[] P5905 { get; set; }
        public P6573[] P6573 { get; set; }
        public P5821[] P5821 { get; set; }
        public P5739[] P5739 { get; set; }
        public P68442[] P6844 { get; set; }
        public P6873[] P6873 { get; set; }
        public P6907[] P6907 { get; set; }
        public P4104[] P4104 { get; set; }
        public P7029[] P7029 { get; set; }
        public P7208[] P7208 { get; set; }
        public P7311[] P7311 { get; set; }
        public P50341[] P5034 { get; set; }
        public P3365[] P3365 { get; set; }
        public P4223[] P4223 { get; set; }
        public P7507[] P7507 { get; set; }
        public P7504[] P7504 { get; set; }
        public P4342[] P4342 { get; set; }
        public P7704[] P7704 { get; set; }
        public P7753[] P7753 { get; set; }
        public P779614[] P7796 { get; set; }
        public P2600[] P2600 { get; set; }
        public P7818[] P7818 { get; set; }
        public P7829[] P7829 { get; set; }
        public P7827[] P7827 { get; set; }
        public P6058[] P6058 { get; set; }
        public P6412[] P6412 { get; set; }
        public P7902[] P7902 { get; set; }
        public P2632[] P2632 { get; set; }
        public P7859[] P7859 { get; set; }
        public P7763[] P7763 { get; set; }
        public P2579[] P2579 { get; set; }
        public P7865[] P7865 { get; set; }
        public P6886[] P6886 { get; set; }
        public P8234[] P8234 { get; set; }
        public P1309[] P1309 { get; set; }
        public P1368[] P1368 { get; set; }
        public P7026[] P7026 { get; set; }
        public P6394[] P6394 { get; set; }
        public P3846[] P3846 { get; set; }
        public P1375[] P1375 { get; set; }
        public P7369[] P7369 { get; set; }
        public P3065[] P3065 { get; set; }
        public P8179[] P8179 { get; set; }
        public P271[] P271 { get; set; }
        public P5504[] P5504 { get; set; }
        public P4619[] P4619 { get; set; }
        public P7024[] P7024 { get; set; }
        public P3280[] P3280 { get; set; }
        public P72931[] P7293 { get; set; }
        public P8189[] P8189 { get; set; }
        public P1695[] P1695 { get; set; }
        public P1890[] P1890 { get; set; }
        public P7699[] P7699 { get; set; }
        public P1884[] P1884 { get; set; }
        public P6403[] P6403 { get; set; }
        public P8317[] P8317 { get; set; }
        public P80341[] P8034 { get; set; }
        public P8385[] P8385 { get; set; }
        public P8496[] P8496 { get; set; }
        public P7982[] P7982 { get; set; }
        public P8589[] P8589 { get; set; }
        public P5063[] P5063 { get; set; }
        public P80941[] P8094 { get; set; }
        public P79291[] P7929 { get; set; }
        public P87501[] P8750 { get; set; }
        public P5273[] P5273 { get; set; }
        public P4839[] P4839 { get; set; }
        public P1150[] P1150 { get; set; }
        public P6327[] P6327 { get; set; }
        public P6517[] P6517 { get; set; }
        public P2011[] P2011 { get; set; }
        public P3980[] P3980 { get; set; }
        public P4808[] P4808 { get; set; }
        public P6104[] P6104 { get; set; }
        public P87951[] P8795 { get; set; }
        public P8826[] P8826 { get; set; }
        public P88331[] P8833 { get; set; }
        public P88491[] P8849 { get; set; }
        public P88511[] P8851 { get; set; }
        public P8947[] P8947 { get; set; }
        public P8974[] P8974 { get; set; }
        public P8980[] P8980 { get; set; }
        public P90371[] P9037 { get; set; }
        public P7444[] P7444 { get; set; }
        public P9081[] P9081 { get; set; }
        public P2561[] P2561 { get; set; }
        public P8814[] P8814 { get; set; }
        public P9179[] P9179 { get; set; }
        public P9226[] P9226 { get; set; }
        public P8885[] P8885 { get; set; }
        public P5421[] P5421 { get; set; }
        public P9223[] P9223 { get; set; }
        public P9251[] P9251 { get; set; }
        public P9282[] P9282 { get; set; }
        public P9141[] P9141 { get; set; }
        public P6683[] P6683 { get; set; }
        public P7700[] P7700 { get; set; }
        public P5617[] P5617 { get; set; }
        public P1449[] P1449 { get; set; }
        public P737[] P737 { get; set; }
        public P18[] P18 { get; set; }
        public P9507[] P9507 { get; set; }
        public P9522[] P9522 { get; set; }
        public P9563[] P9563 { get; set; }
        public P9493[] P9493 { get; set; }
        public P6379[] P6379 { get; set; }
        public P9619[] P9619 { get; set; }
        public P4985[] P4985 { get; set; }
        public P101[] P101 { get; set; }
        public P9337[] P9337 { get; set; }
        public P9686[] P9686 { get; set; }
        public P4084[] P4084 { get; set; }
        public P9780[] P9780 { get; set; }
        public P9807[] P9807 { get; set; }
        public P7212[] P7212 { get; set; }
        public P9918[] P9918 { get; set; }
        public P9984[] P9984 { get; set; }
        public P91521[] P9152 { get; set; }
        public P10242[] P10242 { get; set; }
        public P8349[] P8349 { get; set; }
        public P9466[] P9466 { get; set; }
        public P7305[] P7305 { get; set; }
        public P10297[] P10297 { get; set; }
        public P6645[] P6645 { get; set; }
        public P1260[] P1260 { get; set; }
        public P701[] P701 { get; set; }
        public P10141[] P10141 { get; set; }
        public P10553[] P10553 { get; set; }
        public P8591[] P8591 { get; set; }
        public P8410[] P8410 { get; set; }
        public P6385[] P6385 { get; set; }
        public P10565[] P10565 { get; set; }
        public P9495[] P9495 { get; set; }
        public P10266[] P10266 { get; set; }
        public P10883[] P10883 { get; set; }
        public P8168[] P8168 { get; set; }
        public P10227[] P10227 { get; set; }
        public P10021[] P10021 { get; set; }
        public P10527[] P10527 { get; set; }
        public P7400[] P7400 { get; set; }
        public P1299[] P1299 { get; set; }
        public P11156[] P11156 { get; set; }
        public P10302[] P10302 { get; set; }
        public P9247[] P9247 { get; set; }
        public P11249[] P11249 { get; set; }
        public P114961[] P11496 { get; set; }
        public P2607[] P2607 { get; set; }
    }

    public class P103
    {
        public Mainsnak mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue
    {
        public Value value { get; set; }
        public string type { get; set; }
    }

    public class Value
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P27
    {
        public Mainsnak1 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference[] references { get; set; }
    }

    public class Mainsnak1
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue1 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue1
    {
        public Value1 value { get; set; }
        public string type { get; set; }
    }

    public class Value1
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference
    {
        public string hash { get; set; }
        public Snaks snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks
    {
        public P854[] P854 { get; set; }
    }

    public class P854
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue2 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue2
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P106
    {
        public Mainsnak2 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference1[] references { get; set; }
    }

    public class Mainsnak2
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue3 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue3
    {
        public Value2 value { get; set; }
        public string type { get; set; }
    }

    public class Value2
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference1
    {
        public string hash { get; set; }
        public Snaks1 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks1
    {
        public P248[] P248 { get; set; }
        public P6844[] P6844 { get; set; }
        public P8541[] P854 { get; set; }
        public P813[] P813 { get; set; }
        public P143[] P143 { get; set; }
        public P7796[] P7796 { get; set; }
        public P1810[] P1810 { get; set; }
        public P1476[] P1476 { get; set; }
    }

    public class P248
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue4 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue4
    {
        public Value3 value { get; set; }
        public string type { get; set; }
    }

    public class Value3
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P6844
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue5 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue5
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8541
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue6 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue6
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P813
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue7 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue7
    {
        public Value4 value { get; set; }
        public string type { get; set; }
    }

    public class Value4
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P143
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue8 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue8
    {
        public Value5 value { get; set; }
        public string type { get; set; }
    }

    public class Value5
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P7796
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue9 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue9
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1810
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue10 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue10
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1476
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue11 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue11
    {
        public Value6 value { get; set; }
        public string type { get; set; }
    }

    public class Value6
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P214
    {
        public Mainsnak3 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference2[] references { get; set; }
    }

    public class Mainsnak3
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue12 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue12
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference2
    {
        public string hash { get; set; }
        public Snaks2 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks2
    {
        public P1431[] P143 { get; set; }
    }

    public class P1431
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue13 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue13
    {
        public Value7 value { get; set; }
        public string type { get; set; }
    }

    public class Value7
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P244
    {
        public Mainsnak4 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference3[] references { get; set; }
    }

    public class Mainsnak4
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue14 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue14
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers
    {
        public P18101[] P1810 { get; set; }
    }

    public class P18101
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue15 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue15
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference3
    {
        public string hash { get; set; }
        public Snaks3 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks3
    {
        public P1432[] P143 { get; set; }
        public P2481[] P248 { get; set; }
        public P8131[] P813 { get; set; }
        public P77961[] P7796 { get; set; }
    }

    public class P1432
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue16 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue16
    {
        public Value8 value { get; set; }
        public string type { get; set; }
    }

    public class Value8
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2481
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue17 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue17
    {
        public Value9 value { get; set; }
        public string type { get; set; }
    }

    public class Value9
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8131
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue18 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue18
    {
        public Value10 value { get; set; }
        public string type { get; set; }
    }

    public class Value10
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77961
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue19 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue19
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P227
    {
        public Mainsnak5 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference4[] references { get; set; }
    }

    public class Mainsnak5
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue20 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue20
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference4
    {
        public string hash { get; set; }
        public Snaks4 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks4
    {
        public P1433[] P143 { get; set; }
        public P2482[] P248 { get; set; }
        public P8132[] P813 { get; set; }
        public P77962[] P7796 { get; set; }
    }

    public class P1433
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue21 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue21
    {
        public Value11 value { get; set; }
        public string type { get; set; }
    }

    public class Value11
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2482
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue22 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue22
    {
        public Value12 value { get; set; }
        public string type { get; set; }
    }

    public class Value12
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8132
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue23 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue23
    {
        public Value13 value { get; set; }
        public string type { get; set; }
    }

    public class Value13
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77962
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue24 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue24
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P213
    {
        public Mainsnak6 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference5[] references { get; set; }
    }

    public class Mainsnak6
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue25 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue25
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference5
    {
        public string hash { get; set; }
        public Snaks5 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks5
    {
        public P2483[] P248 { get; set; }
        public P8133[] P813 { get; set; }
        public P77963[] P7796 { get; set; }
    }

    public class P2483
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue26 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue26
    {
        public Value14 value { get; set; }
        public string type { get; set; }
    }

    public class Value14
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8133
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue27 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue27
    {
        public Value15 value { get; set; }
        public string type { get; set; }
    }

    public class Value15
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77963
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue28 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue28
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P434
    {
        public Mainsnak7 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference6[] references { get; set; }
    }

    public class Mainsnak7
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue29 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue29
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference6
    {
        public string hash { get; set; }
        public Snaks6 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks6
    {
        public P2484[] P248 { get; set; }
    }

    public class P2484
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue30 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue30
    {
        public Value16 value { get; set; }
        public string type { get; set; }
    }

    public class Value16
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P373
    {
        public Mainsnak8 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak8
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue31 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue31
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P20
    {
        public Mainsnak9 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers1 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference7[] references { get; set; }
    }

    public class Mainsnak9
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue32 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue32
    {
        public Value17 value { get; set; }
        public string type { get; set; }
    }

    public class Value17
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers1
    {
        public P17[] P17 { get; set; }
    }

    public class P17
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue33 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue33
    {
        public Value18 value { get; set; }
        public string type { get; set; }
    }

    public class Value18
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference7
    {
        public string hash { get; set; }
        public Snaks7 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks7
    {
        public P1434[] P143 { get; set; }
        public P2485[] P248 { get; set; }
        public P8134[] P813 { get; set; }
    }

    public class P1434
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue34 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue34
    {
        public Value19 value { get; set; }
        public string type { get; set; }
    }

    public class Value19
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2485
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue35 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue35
    {
        public Value20 value { get; set; }
        public string type { get; set; }
    }

    public class Value20
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8134
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue36 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue36
    {
        public Value21 value { get; set; }
        public string type { get; set; }
    }

    public class Value21
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P569
    {
        public Mainsnak10 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers2 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference8[] references { get; set; }
    }

    public class Mainsnak10
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue37 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue37
    {
        public Value22 value { get; set; }
        public string type { get; set; }
    }

    public class Value22
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class Qualifiers2
    {
        public P1480[] P1480 { get; set; }
    }

    public class P1480
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue38 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue38
    {
        public Value23 value { get; set; }
        public string type { get; set; }
    }

    public class Value23
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference8
    {
        public string hash { get; set; }
        public Snaks8 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks8
    {
        public P8542[] P854 { get; set; }
        public P2486[] P248 { get; set; }
        public P8135[] P813 { get; set; }
        public P77964[] P7796 { get; set; }
        public P18102[] P1810 { get; set; }
        public P8795[] P8795 { get; set; }
        public P8849[] P8849 { get; set; }
        public P5034[] P5034 { get; set; }
        public P8851[] P8851 { get; set; }
        public P5101[] P5101 { get; set; }
        public P1005[] P1005 { get; set; }
        public P8833[] P8833 { get; set; }
        public P8034[] P8034 { get; set; }
        public P8750[] P8750 { get; set; }
        public P9037[] P9037 { get; set; }
        public P7293[] P7293 { get; set; }
        public P14761[] P1476 { get; set; }
    }

    public class P8542
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue39 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue39
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2486
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue40 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue40
    {
        public Value24 value { get; set; }
        public string type { get; set; }
    }

    public class Value24
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8135
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue41 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue41
    {
        public Value25 value { get; set; }
        public string type { get; set; }
    }

    public class Value25
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77964
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue42 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue42
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P18102
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue43 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue43
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8795
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue44 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue44
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8849
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue45 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue45
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5034
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue46 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue46
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8851
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue47 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue47
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5101
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue48 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue48
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1005
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue49 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue49
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8833
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue50 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue50
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8034
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue51 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue51
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8750
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue52 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue52
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9037
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue53 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue53
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7293
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue54 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue54
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P14761
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue55 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue55
    {
        public Value26 value { get; set; }
        public string type { get; set; }
    }

    public class Value26
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P570
    {
        public Mainsnak11 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference9[] references { get; set; }
    }

    public class Mainsnak11
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue56 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue56
    {
        public Value27 value { get; set; }
        public string type { get; set; }
    }

    public class Value27
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class Reference9
    {
        public string hash { get; set; }
        public Snaks9 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks9
    {
        public P2487[] P248 { get; set; }
        public P8136[] P813 { get; set; }
        public P8543[] P854 { get; set; }
        public P3430[] P3430 { get; set; }
        public P18103[] P1810 { get; set; }
        public P1435[] P143 { get; set; }
        public P1233[] P1233 { get; set; }
        public P5570[] P5570 { get; set; }
        public P1220[] P1220 { get; set; }
        public P1296[] P1296 { get; set; }
        public P8094[] P8094 { get; set; }
        public P7929[] P7929 { get; set; }
        public P77965[] P7796 { get; set; }
        public P68441[] P6844 { get; set; }
        public P14762[] P1476 { get; set; }
    }

    public class P2487
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue57 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue57
    {
        public Value28 value { get; set; }
        public string type { get; set; }
    }

    public class Value28
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8136
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue58 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue58
    {
        public Value29 value { get; set; }
        public string type { get; set; }
    }

    public class Value29
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P8543
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue59 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue59
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3430
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue60 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue60
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P18103
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue61 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue61
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1435
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue62 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue62
    {
        public Value30 value { get; set; }
        public string type { get; set; }
    }

    public class Value30
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1233
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue63 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue63
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5570
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue64 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue64
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1220
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue65 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue65
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1296
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue66 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue66
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8094
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue67 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue67
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7929
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue68 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue68
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P77965
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue69 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue69
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P68441
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue70 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue70
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P14762
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue71 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue71
    {
        public Value31 value { get; set; }
        public string type { get; set; }
    }

    public class Value31
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P691
    {
        public Mainsnak12 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak12
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue72 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue72
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P910
    {
        public Mainsnak13 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak13
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue73 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue73
    {
        public Value32 value { get; set; }
        public string type { get; set; }
    }

    public class Value32
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P268
    {
        public Mainsnak14 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak14
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue74 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue74
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P947
    {
        public Mainsnak15 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference10[] references { get; set; }
    }

    public class Mainsnak15
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue75 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue75
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference10
    {
        public string hash { get; set; }
        public Snaks10 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks10
    {
        public P1436[] P143 { get; set; }
    }

    public class P1436
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue76 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue76
    {
        public Value33 value { get; set; }
        public string type { get; set; }
    }

    public class Value33
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P349
    {
        public Mainsnak16 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak16
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue77 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue77
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P269
    {
        public Mainsnak17 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak17
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue78 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue78
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P31
    {
        public Mainsnak18 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference11[] references { get; set; }
    }

    public class Mainsnak18
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue79 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue79
    {
        public Value34 value { get; set; }
        public string type { get; set; }
    }

    public class Value34
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference11
    {
        public string hash { get; set; }
        public Snaks11 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks11
    {
        public P1437[] P143 { get; set; }
        public P2488[] P248 { get; set; }
        public P8137[] P813 { get; set; }
        public P77966[] P7796 { get; set; }
    }

    public class P1437
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue80 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue80
    {
        public Value35 value { get; set; }
        public string type { get; set; }
    }

    public class Value35
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2488
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue81 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue81
    {
        public Value36 value { get; set; }
        public string type { get; set; }
    }

    public class Value36
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8137
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue82 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue82
    {
        public Value37 value { get; set; }
        public string type { get; set; }
    }

    public class Value37
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77966
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue83 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue83
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P646
    {
        public Mainsnak19 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference12[] references { get; set; }
    }

    public class Mainsnak19
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue84 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue84
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference12
    {
        public string hash { get; set; }
        public Snaks12 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks12
    {
        public P2489[] P248 { get; set; }
        public P577[] P577 { get; set; }
    }

    public class P2489
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue85 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue85
    {
        public Value38 value { get; set; }
        public string type { get; set; }
    }

    public class Value38
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P577
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue86 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue86
    {
        public Value39 value { get; set; }
        public string type { get; set; }
    }

    public class Value39
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P109
    {
        public Mainsnak20 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference13[] references { get; set; }
    }

    public class Mainsnak20
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue87 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue87
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference13
    {
        public string hash { get; set; }
        public Snaks13 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks13
    {
        public P1438[] P143 { get; set; }
    }

    public class P1438
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue88 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue88
    {
        public Value40 value { get; set; }
        public string type { get; set; }
    }

    public class Value40
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1207
    {
        public Mainsnak21 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak21
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue89 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue89
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1006
    {
        public Mainsnak22 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak22
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue90 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue90
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P950
    {
        public Mainsnak23 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak23
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue91 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue91
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1017
    {
        public Mainsnak24 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference14[] references { get; set; }
    }

    public class Mainsnak24
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue92 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue92
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference14
    {
        public string hash { get; set; }
        public Snaks14 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks14
    {
        public P24810[] P248 { get; set; }
        public P8138[] P813 { get; set; }
        public P77967[] P7796 { get; set; }
    }

    public class P24810
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue93 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue93
    {
        public Value41 value { get; set; }
        public string type { get; set; }
    }

    public class Value41
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8138
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue94 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue94
    {
        public Value42 value { get; set; }
        public string type { get; set; }
    }

    public class Value42
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77967
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue95 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue95
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10051
    {
        public Mainsnak25 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak25
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue96 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue96
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P906
    {
        public Mainsnak26 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak26
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue97 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue97
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P396
    {
        public Mainsnak27 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers3 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference15[] references { get; set; }
    }

    public class Mainsnak27
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue98 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue98
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers3
    {
        public P18104[] P1810 { get; set; }
    }

    public class P18104
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue99 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue99
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference15
    {
        public string hash { get; set; }
        public Snaks15 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks15
    {
        public P24811[] P248 { get; set; }
        public P8139[] P813 { get; set; }
        public P77968[] P7796 { get; set; }
    }

    public class P24811
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue100 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue100
    {
        public Value43 value { get; set; }
        public string type { get; set; }
    }

    public class Value43
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8139
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue101 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue101
    {
        public Value44 value { get; set; }
        public string type { get; set; }
    }

    public class Value44
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77968
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue102 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue102
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P735
    {
        public Mainsnak28 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference16[] references { get; set; }
    }

    public class Mainsnak28
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue103 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue103
    {
        public Value45 value { get; set; }
        public string type { get; set; }
    }

    public class Value45
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference16
    {
        public string hash { get; set; }
        public Snaks16 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks16
    {
        public P1439[] P143 { get; set; }
        public P24812[] P248 { get; set; }
        public P2131[] P213 { get; set; }
        public P81310[] P813 { get; set; }
        public P77969[] P7796 { get; set; }
    }

    public class P1439
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue104 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue104
    {
        public Value46 value { get; set; }
        public string type { get; set; }
    }

    public class Value46
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P24812
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue105 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue105
    {
        public Value47 value { get; set; }
        public string type { get; set; }
    }

    public class Value47
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2131
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue106 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue106
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81310
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue107 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue107
    {
        public Value48 value { get; set; }
        public string type { get; set; }
    }

    public class Value48
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P77969
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue108 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue108
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P800
    {
        public Mainsnak29 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers4 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference17[] references { get; set; }
    }

    public class Mainsnak29
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue109 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue109
    {
        public Value49 value { get; set; }
        public string type { get; set; }
    }

    public class Value49
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers4
    {
        public P585[] P585 { get; set; }
        public P5771[] P577 { get; set; }
    }

    public class P585
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue110 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue110
    {
        public Value50 value { get; set; }
        public string type { get; set; }
    }

    public class Value50
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P5771
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue111 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue111
    {
        public Value51 value { get; set; }
        public string type { get; set; }
    }

    public class Value51
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class Reference17
    {
        public string hash { get; set; }
        public Snaks17 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks17
    {
        public P14310[] P143 { get; set; }
    }

    public class P14310
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue112 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue112
    {
        public Value52 value { get; set; }
        public string type { get; set; }
    }

    public class Value52
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1273
    {
        public Mainsnak30 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference18[] references { get; set; }
    }

    public class Mainsnak30
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue113 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue113
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference18
    {
        public string hash { get; set; }
        public Snaks18 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks18
    {
        public P8544[] P854 { get; set; }
    }

    public class P8544
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue114 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue114
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1430
    {
        public Mainsnak31 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak31
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue115 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue115
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P345
    {
        public Mainsnak32 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference19[] references { get; set; }
    }

    public class Mainsnak32
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue116 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue116
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference19
    {
        public string hash { get; set; }
        public Snaks19 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks19
    {
        public P14311[] P143 { get; set; }
    }

    public class P14311
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue117 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue117
    {
        public Value53 value { get; set; }
        public string type { get; set; }
    }

    public class Value53
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1472
    {
        public Mainsnak33 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak33
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue118 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue118
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P866
    {
        public Mainsnak34 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak34
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue119 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue119
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P723
    {
        public Mainsnak35 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak35
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue120 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue120
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1636
    {
        public Mainsnak36 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference20[] references { get; set; }
    }

    public class Mainsnak36
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue121 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue121
    {
        public Value54 value { get; set; }
        public string type { get; set; }
    }

    public class Value54
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class Reference20
    {
        public string hash { get; set; }
        public Snaks20 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks20
    {
        public P8545[] P854 { get; set; }
    }

    public class P8545
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue122 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue122
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1015
    {
        public Mainsnak37 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference21[] references { get; set; }
    }

    public class Mainsnak37
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue123 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue123
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference21
    {
        public string hash { get; set; }
        public Snaks21 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks21
    {
        public P8546[] P854 { get; set; }
    }

    public class P8546
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue124 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue124
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P119
    {
        public Mainsnak38 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference22[] references { get; set; }
    }

    public class Mainsnak38
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue125 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue125
    {
        public Value55 value { get; set; }
        public string type { get; set; }
    }

    public class Value55
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference22
    {
        public string hash { get; set; }
        public Snaks22 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks22
    {
        public P8547[] P854 { get; set; }
        public P123[] P123 { get; set; }
        public P5772[] P577 { get; set; }
        public P81311[] P813 { get; set; }
    }

    public class P8547
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue126 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue126
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P123
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue127 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue127
    {
        public Value56 value { get; set; }
        public string type { get; set; }
    }

    public class Value56
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P5772
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue128 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue128
    {
        public Value57 value { get; set; }
        public string type { get; set; }
    }

    public class Value57
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P81311
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue129 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue129
    {
        public Value58 value { get; set; }
        public string type { get; set; }
    }

    public class Value58
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P1263
    {
        public Mainsnak39 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak39
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue130 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue130
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1711
    {
        public Mainsnak40 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak40
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue131 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue131
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1741
    {
        public Mainsnak41 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak41
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue132 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue132
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1559
    {
        public Mainsnak42 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak42
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue133 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue133
    {
        public Value59 value { get; set; }
        public string type { get; set; }
    }

    public class Value59
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P1938
    {
        public Mainsnak43 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak43
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue134 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue134
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P19
    {
        public Mainsnak44 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers5 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference23[] references { get; set; }
    }

    public class Mainsnak44
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue135 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue135
    {
        public Value60 value { get; set; }
        public string type { get; set; }
    }

    public class Value60
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers5
    {
        public P171[] P17 { get; set; }
    }

    public class P171
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue136 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue136
    {
        public Value61 value { get; set; }
        public string type { get; set; }
    }

    public class Value61
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference23
    {
        public string hash { get; set; }
        public Snaks23 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks23
    {
        public P14312[] P143 { get; set; }
        public P8548[] P854 { get; set; }
    }

    public class P14312
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue137 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue137
    {
        public Value62 value { get; set; }
        public string type { get; set; }
    }

    public class Value62
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P8548
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue138 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue138
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P40
    {
        public Mainsnak45 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak45
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue139 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue139
    {
        public Value63 value { get; set; }
        public string type { get; set; }
    }

    public class Value63
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1266
    {
        public Mainsnak46 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak46
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue140 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue140
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P648
    {
        public Mainsnak47 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak47
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue141 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue141
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1565
    {
        public Mainsnak48 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak48
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue142 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue142
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2252
    {
        public Mainsnak49 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak49
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue143 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue143
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1412
    {
        public Mainsnak50 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference24[] references { get; set; }
    }

    public class Mainsnak50
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue144 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue144
    {
        public Value64 value { get; set; }
        public string type { get; set; }
    }

    public class Value64
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference24
    {
        public string hash { get; set; }
        public Snaks24 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks24
    {
        public P14313[] P143 { get; set; }
        public P24813[] P248 { get; set; }
        public P6911[] P691 { get; set; }
        public P81312[] P813 { get; set; }
    }

    public class P14313
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue145 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue145
    {
        public Value65 value { get; set; }
        public string type { get; set; }
    }

    public class Value65
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P24813
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue146 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue146
    {
        public Value66 value { get; set; }
        public string type { get; set; }
    }

    public class Value66
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P6911
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue147 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue147
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81312
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue148 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue148
    {
        public Value67 value { get; set; }
        public string type { get; set; }
    }

    public class Value67
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P1315
    {
        public Mainsnak51 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak51
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue149 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue149
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P136
    {
        public Mainsnak52 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference25[] references { get; set; }
    }

    public class Mainsnak52
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue150 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue150
    {
        public Value68 value { get; set; }
        public string type { get; set; }
    }

    public class Value68
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference25
    {
        public string hash { get; set; }
        public Snaks25 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks25
    {
        public P14314[] P143 { get; set; }
    }

    public class P14314
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue151 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue151
    {
        public Value69 value { get; set; }
        public string type { get; set; }
    }

    public class Value69
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P935
    {
        public Mainsnak53 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak53
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue152 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue152
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1343
    {
        public Mainsnak54 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Qualifiers6 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public Reference26[] references { get; set; }
    }

    public class Mainsnak54
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue153 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue153
    {
        public Value70 value { get; set; }
        public string type { get; set; }
    }

    public class Value70
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers6
    {
        public P805[] P805 { get; set; }
        public P2699[] P2699 { get; set; }
        public P18105[] P1810 { get; set; }
    }

    public class P805
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue154 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue154
    {
        public Value71 value { get; set; }
        public string type { get; set; }
    }

    public class Value71
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2699
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue155 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue155
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P18105
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue156 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue156
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference26
    {
        public string hash { get; set; }
        public Snaks26 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks26
    {
        public P24814[] P248 { get; set; }
        public P81313[] P813 { get; set; }
        public P8549[] P854 { get; set; }
    }

    public class P24814
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue157 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue157
    {
        public Value72 value { get; set; }
        public string type { get; set; }
    }

    public class Value72
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81313
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue158 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue158
    {
        public Value73 value { get; set; }
        public string type { get; set; }
    }

    public class Value73
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P8549
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue159 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue159
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1871
    {
        public Mainsnak55 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference27[] references { get; set; }
    }

    public class Mainsnak55
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue160 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue160
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference27
    {
        public string hash { get; set; }
        public Snaks27 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks27
    {
        public P24815[] P248 { get; set; }
        public P81314[] P813 { get; set; }
        public P779610[] P7796 { get; set; }
    }

    public class P24815
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue161 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue161
    {
        public Value74 value { get; set; }
        public string type { get; set; }
    }

    public class Value74
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81314
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue162 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue162
    {
        public Value75 value { get; set; }
        public string type { get; set; }
    }

    public class Value75
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P779610
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue163 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue163
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P26
    {
        public Mainsnak56 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak56
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue164 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue164
    {
        public Value76 value { get; set; }
        public string type { get; set; }
    }

    public class Value76
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2163
    {
        public Mainsnak57 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak57
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue165 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue165
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2533
    {
        public Mainsnak58 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak58
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue166 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue166
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1417
    {
        public Mainsnak59 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak59
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue167 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue167
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1280
    {
        public Mainsnak60 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak60
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue168 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue168
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1977
    {
        public Mainsnak61 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak61
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue169 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue169
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2639
    {
        public Mainsnak62 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference28[] references { get; set; }
    }

    public class Mainsnak62
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue170 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue170
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference28
    {
        public string hash { get; set; }
        public Snaks28 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks28
    {
        public P24816[] P248 { get; set; }
        public P81315[] P813 { get; set; }
    }

    public class P24816
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue171 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue171
    {
        public Value77 value { get; set; }
        public string type { get; set; }
    }

    public class Value77
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81315
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue172 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue172
    {
        public Value78 value { get; set; }
        public string type { get; set; }
    }

    public class Value78
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P12201
    {
        public Mainsnak63 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak63
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue173 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue173
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2435
    {
        public Mainsnak64 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak64
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue174 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue174
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2168
    {
        public Mainsnak65 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak65
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue175 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue175
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2019
    {
        public Mainsnak66 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak66
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue176 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue176
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2604
    {
        public Mainsnak67 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak67
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue177 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue177
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2605
    {
        public Mainsnak68 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak68
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue178 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue178
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1899
    {
        public Mainsnak69 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference29[] references { get; set; }
    }

    public class Mainsnak69
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue179 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue179
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference29
    {
        public string hash { get; set; }
        public Snaks29 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks29
    {
        public P14315[] P143 { get; set; }
    }

    public class P14315
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue180 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue180
    {
        public Value79 value { get; set; }
        public string type { get; set; }
    }

    public class Value79
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P409
    {
        public Mainsnak70 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak70
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue181 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue181
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P245
    {
        public Mainsnak71 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak71
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue182 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue182
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2799
    {
        public Mainsnak72 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak72
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue183 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue183
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P12961
    {
        public Mainsnak73 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak73
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue184 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue184
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1196
    {
        public Mainsnak74 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak74
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue185 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue185
    {
        public Value80 value { get; set; }
        public string type { get; set; }
    }

    public class Value80
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2188
    {
        public Mainsnak75 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak75
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue186 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue186
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2469
    {
        public Mainsnak76 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak76
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue187 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue187
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3348
    {
        public Mainsnak77 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak77
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue188 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue188
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P34301
    {
        public Mainsnak78 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak78
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue189 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue189
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3417
    {
        public Mainsnak79 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference30[] references { get; set; }
    }

    public class Mainsnak79
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue190 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue190
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference30
    {
        public string hash { get; set; }
        public Snaks30 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks30
    {
        public P24817[] P248 { get; set; }
    }

    public class P24817
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue191 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue191
    {
        public Value81 value { get; set; }
        public string type { get; set; }
    }

    public class Value81
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3762
    {
        public Mainsnak80 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak80
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue192 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue192
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2949
    {
        public Mainsnak81 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers7 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak81
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue193 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue193
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers7
    {
        public P18106[] P1810 { get; set; }
    }

    public class P18106
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue194 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue194
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3788
    {
        public Mainsnak82 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak82
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue195 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue195
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3932
    {
        public Mainsnak83 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak83
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue196 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue196
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3964
    {
        public Mainsnak84 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak84
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue197 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue197
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3965
    {
        public Mainsnak85 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak85
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue198 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue198
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4145
    {
        public Mainsnak86 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak86
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue199 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue199
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3782
    {
        public Mainsnak87 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak87
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue200 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue200
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2886
    {
        public Mainsnak88 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference31[] references { get; set; }
    }

    public class Mainsnak88
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue201 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue201
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference31
    {
        public string hash { get; set; }
        public Snaks31 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks31
    {
        public P18107[] P1810 { get; set; }
        public P24818[] P248 { get; set; }
        public P81316[] P813 { get; set; }
    }

    public class P18107
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue202 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue202
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P24818
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue203 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue203
    {
        public Value82 value { get; set; }
        public string type { get; set; }
    }

    public class Value82
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81316
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue204 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue204
    {
        public Value83 value { get; set; }
        public string type { get; set; }
    }

    public class Value83
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P135
    {
        public Mainsnak89 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak89
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue205 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue205
    {
        public Value84 value { get; set; }
        public string type { get; set; }
    }

    public class Value84
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3241
    {
        public Mainsnak90 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak90
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue206 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue206
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4399
    {
        public Mainsnak91 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak91
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue207 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue207
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1728
    {
        public Mainsnak92 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference32[] references { get; set; }
    }

    public class Mainsnak92
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue208 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue208
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference32
    {
        public string hash { get; set; }
        public Snaks32 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks32
    {
        public P24819[] P248 { get; set; }
    }

    public class P24819
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue209 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue209
    {
        public Value85 value { get; set; }
        public string type { get; set; }
    }

    public class Value85
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3192
    {
        public Mainsnak93 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference33[] references { get; set; }
    }

    public class Mainsnak93
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue210 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue210
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference33
    {
        public string hash { get; set; }
        public Snaks33 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks33
    {
        public P24820[] P248 { get; set; }
    }

    public class P24820
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue211 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue211
    {
        public Value86 value { get; set; }
        public string type { get; set; }
    }

    public class Value86
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1953
    {
        public Mainsnak94 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference34[] references { get; set; }
    }

    public class Mainsnak94
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue212 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue212
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference34
    {
        public string hash { get; set; }
        public Snaks34 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks34
    {
        public P24821[] P248 { get; set; }
    }

    public class P24821
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue213 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue213
    {
        public Value87 value { get; set; }
        public string type { get; set; }
    }

    public class Value87
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P4431
    {
        public Mainsnak95 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak95
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue214 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue214
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P734
    {
        public Mainsnak96 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference35[] references { get; set; }
    }

    public class Mainsnak96
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue215 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue215
    {
        public Value88 value { get; set; }
        public string type { get; set; }
    }

    public class Value88
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference35
    {
        public string hash { get; set; }
        public Snaks35 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks35
    {
        public P24822[] P248 { get; set; }
        public P81317[] P813 { get; set; }
        public P779611[] P7796 { get; set; }
    }

    public class P24822
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue216 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue216
    {
        public Value89 value { get; set; }
        public string type { get; set; }
    }

    public class Value89
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81317
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue217 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue217
    {
        public Value90 value { get; set; }
        public string type { get; set; }
    }

    public class Value90
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P779611
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue218 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue218
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4459
    {
        public Mainsnak97 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak97
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue219 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue219
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1607
    {
        public Mainsnak98 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak98
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue220 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue220
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4553
    {
        public Mainsnak99 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference36[] references { get; set; }
    }

    public class Mainsnak99
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue221 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue221
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference36
    {
        public string hash { get; set; }
        public Snaks36 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks36
    {
        public P14316[] P143 { get; set; }
    }

    public class P14316
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue222 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue222
    {
        public Value91 value { get; set; }
        public string type { get; set; }
    }

    public class Value91
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3630
    {
        public Mainsnak100 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak100
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue223 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue223
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4629
    {
        public Mainsnak101 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak101
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue224 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue224
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P839
    {
        public Mainsnak102 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak102
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue225 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue225
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3154
    {
        public Mainsnak103 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak103
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue226 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue226
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1828
    {
        public Mainsnak104 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers8 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference37[] references { get; set; }
    }

    public class Mainsnak104
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue227 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue227
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers8
    {
        public P18108[] P1810 { get; set; }
    }

    public class P18108
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue228 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue228
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference37
    {
        public string hash { get; set; }
        public Snaks37 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks37
    {
        public P14317[] P143 { get; set; }
    }

    public class P14317
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue229 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue229
    {
        public Value92 value { get; set; }
        public string type { get; set; }
    }

    public class Value92
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3219
    {
        public Mainsnak105 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak105
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue230 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue230
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1950
    {
        public Mainsnak106 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak106
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue231 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue231
    {
        public Value93 value { get; set; }
        public string type { get; set; }
    }

    public class Value93
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P451
    {
        public Mainsnak107 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak107
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue232 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue232
    {
        public Value94 value { get; set; }
        public string type { get; set; }
    }

    public class Value94
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1477
    {
        public Mainsnak108 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak108
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue233 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue233
    {
        public Value95 value { get; set; }
        public string type { get; set; }
    }

    public class Value95
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P1448
    {
        public Mainsnak109 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak109
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue234 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue234
    {
        public Value96 value { get; set; }
        public string type { get; set; }
    }

    public class Value96
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P22
    {
        public Mainsnak110 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak110
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue235 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue235
    {
        public Value97 value { get; set; }
        public string type { get; set; }
    }

    public class Value97
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P25
    {
        public Mainsnak111 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak111
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue236 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue236
    {
        public Value98 value { get; set; }
        public string type { get; set; }
    }

    public class Value98
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P1670
    {
        public Mainsnak112 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak112
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue237 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue237
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P949
    {
        public Mainsnak113 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak113
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue238 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue238
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5008
    {
        public Mainsnak114 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Qualifiers9 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
    }

    public class Mainsnak114
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue239 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue239
    {
        public Value99 value { get; set; }
        public string type { get; set; }
    }

    public class Value99
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers9
    {
        public P5851[] P585 { get; set; }
    }

    public class P5851
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue240 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue240
    {
        public Value100 value { get; set; }
        public string type { get; set; }
    }

    public class Value100
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P5068
    {
        public Mainsnak115 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak115
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue241 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue241
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P51011
    {
        public Mainsnak116 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak116
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue242 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue242
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P12331
    {
        public Mainsnak117 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak117
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue243 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue243
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P69
    {
        public Mainsnak118 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference38[] references { get; set; }
    }

    public class Mainsnak118
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue244 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue244
    {
        public Value101 value { get; set; }
        public string type { get; set; }
    }

    public class Value101
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference38
    {
        public string hash { get; set; }
        public Snaks38 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks38
    {
        public P14318[] P143 { get; set; }
    }

    public class P14318
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue245 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue245
    {
        public Value102 value { get; set; }
        public string type { get; set; }
    }

    public class Value102
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P172
    {
        public Mainsnak119 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers10 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference39[] references { get; set; }
    }

    public class Mainsnak119
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue246 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue246
    {
        public Value103 value { get; set; }
        public string type { get; set; }
    }

    public class Value103
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers10
    {
        public P2241[] P2241 { get; set; }
    }

    public class P2241
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue247 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue247
    {
        public Value104 value { get; set; }
        public string type { get; set; }
    }

    public class Value104
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference39
    {
        public string hash { get; set; }
        public Snaks39 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks39
    {
        public P14319[] P143 { get; set; }
    }

    public class P14319
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue248 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue248
    {
        public Value105 value { get; set; }
        public string type { get; set; }
    }

    public class Value105
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P3987
    {
        public Mainsnak120 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak120
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue249 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue249
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2924
    {
        public Mainsnak121 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak121
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue250 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue250
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4802
    {
        public Mainsnak122 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak122
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue251 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue251
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5361
    {
        public Mainsnak123 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference40[] references { get; set; }
    }

    public class Mainsnak123
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue252 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue252
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference40
    {
        public string hash { get; set; }
        public Snaks40 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks40
    {
        public P4656[] P4656 { get; set; }
    }

    public class P4656
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue253 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue253
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P509
    {
        public Mainsnak124 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak124
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue254 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue254
    {
        public Value106 value { get; set; }
        public string type { get; set; }
    }

    public class Value106
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P140
    {
        public Mainsnak125 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference41[] references { get; set; }
    }

    public class Mainsnak125
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue255 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue255
    {
        public Value107 value { get; set; }
        public string type { get; set; }
    }

    public class Value107
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference41
    {
        public string hash { get; set; }
        public Snaks41 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks41
    {
        public P14320[] P143 { get; set; }
    }

    public class P14320
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue256 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue256
    {
        public Value108 value { get; set; }
        public string type { get; set; }
    }

    public class Value108
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P55701
    {
        public Mainsnak126 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak126
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue257 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue257
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1580
    {
        public Mainsnak127 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak127
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue258 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue258
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5613
    {
        public Mainsnak128 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak128
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue259 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue259
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P535
    {
        public Mainsnak129 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak129
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue260 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue260
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2977
    {
        public Mainsnak130 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak130
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue261 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue261
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5731
    {
        public Mainsnak131 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak131
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue262 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue262
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5587
    {
        public Mainsnak132 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference42[] references { get; set; }
    }

    public class Mainsnak132
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue263 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue263
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference42
    {
        public string hash { get; set; }
        public Snaks42 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks42
    {
        public P24823[] P248 { get; set; }
        public P85410[] P854 { get; set; }
        public P5773[] P577 { get; set; }
        public P81318[] P813 { get; set; }
    }

    public class P24823
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue264 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue264
    {
        public Value109 value { get; set; }
        public string type { get; set; }
    }

    public class Value109
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P85410
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue265 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue265
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5773
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue266 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue266
    {
        public Value110 value { get; set; }
        public string type { get; set; }
    }

    public class Value110
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P81318
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue267 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue267
    {
        public Value111 value { get; set; }
        public string type { get; set; }
    }

    public class Value111
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P3222
    {
        public Mainsnak133 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak133
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue268 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue268
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5951
    {
        public Mainsnak134 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak134
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue269 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue269
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5491
    {
        public Mainsnak135 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak135
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue270 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue270
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P21
    {
        public Mainsnak136 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference43[] references { get; set; }
    }

    public class Mainsnak136
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue271 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue271
    {
        public Value112 value { get; set; }
        public string type { get; set; }
    }

    public class Value112
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference43
    {
        public string hash { get; set; }
        public Snaks43 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks43
    {
        public P24824[] P248 { get; set; }
        public P2141[] P214 { get; set; }
        public P81319[] P813 { get; set; }
        public P779612[] P7796 { get; set; }
    }

    public class P24824
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue272 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue272
    {
        public Value113 value { get; set; }
        public string type { get; set; }
    }

    public class Value113
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2141
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue273 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue273
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81319
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue274 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue274
    {
        public Value114 value { get; set; }
        public string type { get; set; }
    }

    public class Value114
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P779612
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue275 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue275
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6173
    {
        public Mainsnak137 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak137
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue276 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue276
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5905
    {
        public Mainsnak138 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak138
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue277 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue277
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6573
    {
        public Mainsnak139 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak139
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue278 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue278
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5821
    {
        public Mainsnak140 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak140
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue279 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue279
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5739
    {
        public Mainsnak141 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak141
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue280 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue280
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P68442
    {
        public Mainsnak142 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak142
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue281 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue281
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6873
    {
        public Mainsnak143 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak143
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue282 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue282
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6907
    {
        public Mainsnak144 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak144
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue283 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue283
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4104
    {
        public Mainsnak145 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak145
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue284 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue284
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7029
    {
        public Mainsnak146 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak146
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue285 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue285
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7208
    {
        public Mainsnak147 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak147
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue286 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue286
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7311
    {
        public Mainsnak148 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference44[] references { get; set; }
    }

    public class Mainsnak148
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue287 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue287
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference44
    {
        public string hash { get; set; }
        public Snaks44 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks44
    {
        public P14321[] P143 { get; set; }
        public P46561[] P4656 { get; set; }
    }

    public class P14321
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue288 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue288
    {
        public Value115 value { get; set; }
        public string type { get; set; }
    }

    public class Value115
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P46561
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue289 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue289
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P50341
    {
        public Mainsnak149 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak149
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue290 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue290
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3365
    {
        public Mainsnak150 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers11 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference45[] references { get; set; }
    }

    public class Mainsnak150
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue291 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue291
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers11
    {
        public P18109[] P1810 { get; set; }
    }

    public class P18109
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue292 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue292
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference45
    {
        public string hash { get; set; }
        public Snaks45 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks45
    {
        public P24825[] P248 { get; set; }
        public P81320[] P813 { get; set; }
        public P779613[] P7796 { get; set; }
    }

    public class P24825
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue293 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue293
    {
        public Value116 value { get; set; }
        public string type { get; set; }
    }

    public class Value116
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81320
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue294 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue294
    {
        public Value117 value { get; set; }
        public string type { get; set; }
    }

    public class Value117
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P779613
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue295 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue295
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4223
    {
        public Mainsnak151 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers12 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference46[] references { get; set; }
    }

    public class Mainsnak151
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue296 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue296
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers12
    {
        public P181010[] P1810 { get; set; }
        public P2093[] P2093 { get; set; }
        public P5774[] P577 { get; set; }
    }

    public class P181010
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue297 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue297
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2093
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue298 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue298
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5774
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue299 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue299
    {
        public Value118 value { get; set; }
        public string type { get; set; }
    }

    public class Value118
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class Reference46
    {
        public string hash { get; set; }
        public Snaks46 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks46
    {
        public P24826[] P248 { get; set; }
        public P81321[] P813 { get; set; }
    }

    public class P24826
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue300 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue300
    {
        public Value119 value { get; set; }
        public string type { get; set; }
    }

    public class Value119
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81321
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue301 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue301
    {
        public Value120 value { get; set; }
        public string type { get; set; }
    }

    public class Value120
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P7507
    {
        public Mainsnak152 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference47[] references { get; set; }
    }

    public class Mainsnak152
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue302 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue302
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference47
    {
        public string hash { get; set; }
        public Snaks47 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks47
    {
        public P14322[] P143 { get; set; }
        public P46562[] P4656 { get; set; }
    }

    public class P14322
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue303 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue303
    {
        public Value121 value { get; set; }
        public string type { get; set; }
    }

    public class Value121
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P46562
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue304 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue304
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7504
    {
        public Mainsnak153 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference48[] references { get; set; }
    }

    public class Mainsnak153
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue305 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue305
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference48
    {
        public string hash { get; set; }
        public Snaks48 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks48
    {
        public P46563[] P4656 { get; set; }
    }

    public class P46563
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue306 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue306
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4342
    {
        public Mainsnak154 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak154
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue307 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue307
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7704
    {
        public Mainsnak155 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference49[] references { get; set; }
    }

    public class Mainsnak155
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue308 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue308
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference49
    {
        public string hash { get; set; }
        public Snaks49 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks49
    {
        public P81322[] P813 { get; set; }
    }

    public class P81322
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue309 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue309
    {
        public Value122 value { get; set; }
        public string type { get; set; }
    }

    public class Value122
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P7753
    {
        public Mainsnak156 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak156
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue310 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue310
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P779614
    {
        public Mainsnak157 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference50[] references { get; set; }
    }

    public class Mainsnak157
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue311 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue311
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference50
    {
        public string hash { get; set; }
        public Snaks50 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks50
    {
        public P24827[] P248 { get; set; }
        public P81323[] P813 { get; set; }
        public P779615[] P7796 { get; set; }
    }

    public class P24827
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue312 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue312
    {
        public Value123 value { get; set; }
        public string type { get; set; }
    }

    public class Value123
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81323
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue313 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue313
    {
        public Value124 value { get; set; }
        public string type { get; set; }
    }

    public class Value124
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P779615
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue314 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue314
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2600
    {
        public Mainsnak158 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak158
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue315 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue315
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7818
    {
        public Mainsnak159 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak159
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue316 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue316
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7829
    {
        public Mainsnak160 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak160
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue317 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue317
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7827
    {
        public Mainsnak161 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak161
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue318 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue318
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6058
    {
        public Mainsnak162 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak162
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue319 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue319
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6412
    {
        public Mainsnak163 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak163
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue320 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue320
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7902
    {
        public Mainsnak164 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak164
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue321 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue321
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2632
    {
        public Mainsnak165 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers13 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference51[] references { get; set; }
    }

    public class Mainsnak165
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue322 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue322
    {
        public Value125 value { get; set; }
        public string type { get; set; }
    }

    public class Value125
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers13
    {
        public P2047[] P2047 { get; set; }
    }

    public class P2047
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue323 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue323
    {
        public Value126 value { get; set; }
        public string type { get; set; }
    }

    public class Value126
    {
        public string amount { get; set; }
        public string unit { get; set; }
    }

    public class Reference51
    {
        public string hash { get; set; }
        public Snaks51 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks51
    {
        public P957[] P957 { get; set; }
        public P304[] P304 { get; set; }
        public P1683[] P1683 { get; set; }
    }

    public class P957
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue324 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue324
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P304
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue325 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue325
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1683
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue326 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue326
    {
        public Value127 value { get; set; }
        public string type { get; set; }
    }

    public class Value127
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P7859
    {
        public Mainsnak166 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference52[] references { get; set; }
    }

    public class Mainsnak166
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue327 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue327
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference52
    {
        public string hash { get; set; }
        public Snaks52 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks52
    {
        public P2142[] P214 { get; set; }
    }

    public class P2142
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue328 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue328
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7763
    {
        public Mainsnak167 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers14 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference53[] references { get; set; }
    }

    public class Mainsnak167
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue329 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue329
    {
        public Value128 value { get; set; }
        public string type { get; set; }
    }

    public class Value128
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers14
    {
        public P1001[] P1001 { get; set; }
    }

    public class P1001
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue330 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue330
    {
        public Value129 value { get; set; }
        public string type { get; set; }
    }

    public class Value129
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference53
    {
        public string hash { get; set; }
        public Snaks53 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks53
    {
        public P81324[] P813 { get; set; }
        public P887[] P887 { get; set; }
        public P9905[] P9905 { get; set; }
    }

    public class P81324
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue331 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue331
    {
        public Value130 value { get; set; }
        public string type { get; set; }
    }

    public class Value130
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P887
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue332 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue332
    {
        public Value131 value { get; set; }
        public string type { get; set; }
    }

    public class Value131
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P9905
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue333 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue333
    {
        public Value132 value { get; set; }
        public string type { get; set; }
    }

    public class Value132
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P2579
    {
        public Mainsnak168 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak168
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue334 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue334
    {
        public Value133 value { get; set; }
        public string type { get; set; }
    }

    public class Value133
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P7865
    {
        public Mainsnak169 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference54[] references { get; set; }
    }

    public class Mainsnak169
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue335 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue335
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference54
    {
        public string hash { get; set; }
        public Snaks54 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks54
    {
        public P81325[] P813 { get; set; }
    }

    public class P81325
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue336 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue336
    {
        public Value134 value { get; set; }
        public string type { get; set; }
    }

    public class Value134
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P6886
    {
        public Mainsnak170 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference55[] references { get; set; }
    }

    public class Mainsnak170
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue337 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue337
    {
        public Value135 value { get; set; }
        public string type { get; set; }
    }

    public class Value135
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference55
    {
        public string hash { get; set; }
        public Snaks55 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks55
    {
        public P14323[] P143 { get; set; }
        public P46564[] P4656 { get; set; }
    }

    public class P14323
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue338 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue338
    {
        public Value136 value { get; set; }
        public string type { get; set; }
    }

    public class Value136
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P46564
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue339 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue339
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8234
    {
        public Mainsnak171 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak171
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue340 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue340
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1309
    {
        public Mainsnak172 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak172
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue341 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue341
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1368
    {
        public Mainsnak173 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak173
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue342 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue342
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7026
    {
        public Mainsnak174 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak174
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue343 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue343
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6394
    {
        public Mainsnak175 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak175
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue344 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue344
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3846
    {
        public Mainsnak176 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak176
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue345 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue345
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1375
    {
        public Mainsnak177 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak177
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue346 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue346
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7369
    {
        public Mainsnak178 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak178
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue347 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue347
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3065
    {
        public Mainsnak179 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak179
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue348 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue348
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8179
    {
        public Mainsnak180 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak180
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue349 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue349
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P271
    {
        public Mainsnak181 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference56[] references { get; set; }
    }

    public class Mainsnak181
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue350 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue350
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference56
    {
        public string hash { get; set; }
        public Snaks56 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks56
    {
        public P24828[] P248 { get; set; }
        public P11496[] P11496 { get; set; }
        public P81326[] P813 { get; set; }
    }

    public class P24828
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue351 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue351
    {
        public Value137 value { get; set; }
        public string type { get; set; }
    }

    public class Value137
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P11496
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue352 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue352
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81326
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue353 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue353
    {
        public Value138 value { get; set; }
        public string type { get; set; }
    }

    public class Value138
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P5504
    {
        public Mainsnak182 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak182
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue354 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue354
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4619
    {
        public Mainsnak183 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak183
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue355 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue355
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7024
    {
        public Mainsnak184 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak184
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue356 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue356
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3280
    {
        public Mainsnak185 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak185
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue357 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue357
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P72931
    {
        public Mainsnak186 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak186
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue358 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue358
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8189
    {
        public Mainsnak187 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak187
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue359 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue359
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1695
    {
        public Mainsnak188 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak188
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue360 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue360
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1890
    {
        public Mainsnak189 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak189
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue361 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue361
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7699
    {
        public Mainsnak190 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak190
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue362 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue362
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1884
    {
        public Mainsnak191 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak191
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue363 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue363
    {
        public Value139 value { get; set; }
        public string type { get; set; }
    }

    public class Value139
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P6403
    {
        public Mainsnak192 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak192
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue364 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue364
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8317
    {
        public Mainsnak193 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak193
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue365 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue365
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P80341
    {
        public Mainsnak194 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference57[] references { get; set; }
    }

    public class Mainsnak194
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue366 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue366
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference57
    {
        public string hash { get; set; }
        public Snaks57 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks57
    {
        public P2143[] P214 { get; set; }
        public P24829[] P248 { get; set; }
        public P81327[] P813 { get; set; }
    }

    public class P2143
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue367 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue367
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P24829
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue368 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue368
    {
        public Value140 value { get; set; }
        public string type { get; set; }
    }

    public class Value140
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81327
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue369 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue369
    {
        public Value141 value { get; set; }
        public string type { get; set; }
    }

    public class Value141
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P8385
    {
        public Mainsnak195 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference58[] references { get; set; }
    }

    public class Mainsnak195
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue370 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue370
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference58
    {
        public string hash { get; set; }
        public Snaks58 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks58
    {
        public P24830[] P248 { get; set; }
        public P81328[] P813 { get; set; }
    }

    public class P24830
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue371 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue371
    {
        public Value142 value { get; set; }
        public string type { get; set; }
    }

    public class Value142
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81328
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue372 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue372
    {
        public Value143 value { get; set; }
        public string type { get; set; }
    }

    public class Value143
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P8496
    {
        public Mainsnak196 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak196
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue373 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue373
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7982
    {
        public Mainsnak197 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak197
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue374 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue374
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8589
    {
        public Mainsnak198 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak198
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue375 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue375
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5063
    {
        public Mainsnak199 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak199
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue376 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue376
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P80941
    {
        public Mainsnak200 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak200
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue377 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue377
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P79291
    {
        public Mainsnak201 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak201
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue378 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue378
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P87501
    {
        public Mainsnak202 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak202
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue379 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue379
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5273
    {
        public Mainsnak203 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak203
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue380 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue380
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4839
    {
        public Mainsnak204 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak204
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue381 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue381
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1150
    {
        public Mainsnak205 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak205
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue382 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue382
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6327
    {
        public Mainsnak206 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak206
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue383 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue383
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6517
    {
        public Mainsnak207 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak207
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue384 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue384
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2011
    {
        public Mainsnak208 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak208
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue385 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue385
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P3980
    {
        public Mainsnak209 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak209
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue386 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue386
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4808
    {
        public Mainsnak210 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak210
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue387 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue387
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6104
    {
        public Mainsnak211 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak211
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue388 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue388
    {
        public Value144 value { get; set; }
        public string type { get; set; }
    }

    public class Value144
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P87951
    {
        public Mainsnak212 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak212
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue389 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue389
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8826
    {
        public Mainsnak213 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak213
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue390 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue390
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P88331
    {
        public Mainsnak214 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak214
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue391 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue391
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P88491
    {
        public Mainsnak215 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak215
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue392 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue392
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P88511
    {
        public Mainsnak216 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak216
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue393 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue393
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8947
    {
        public Mainsnak217 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak217
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue394 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue394
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8974
    {
        public Mainsnak218 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak218
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue395 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue395
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8980
    {
        public Mainsnak219 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak219
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue396 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue396
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P90371
    {
        public Mainsnak220 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference59[] references { get; set; }
    }

    public class Mainsnak220
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue397 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue397
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference59
    {
        public string hash { get; set; }
        public Snaks59 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks59
    {
        public P24831[] P248 { get; set; }
        public P90372[] P9037 { get; set; }
        public P6912[] P691 { get; set; }
        public P81329[] P813 { get; set; }
    }

    public class P24831
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue398 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue398
    {
        public Value145 value { get; set; }
        public string type { get; set; }
    }

    public class Value145
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P90372
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue399 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue399
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6912
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue400 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue400
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81329
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue401 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue401
    {
        public Value146 value { get; set; }
        public string type { get; set; }
    }

    public class Value146
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P7444
    {
        public Mainsnak221 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak221
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue402 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue402
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9081
    {
        public Mainsnak222 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak222
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue403 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue403
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2561
    {
        public Mainsnak223 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers15 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak223
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue404 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue404
    {
        public Value147 value { get; set; }
        public string type { get; set; }
    }

    public class Value147
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class Qualifiers15
    {
        public P181011[] P1810 { get; set; }
    }

    public class P181011
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue405 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue405
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8814
    {
        public Mainsnak224 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak224
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue406 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue406
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9179
    {
        public Mainsnak225 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak225
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue407 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue407
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9226
    {
        public Mainsnak226 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak226
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue408 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue408
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8885
    {
        public Mainsnak227 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak227
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue409 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue409
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P5421
    {
        public Mainsnak228 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak228
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue410 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue410
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9223
    {
        public Mainsnak229 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference60[] references { get; set; }
    }

    public class Mainsnak229
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue411 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue411
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference60
    {
        public string hash { get; set; }
        public Snaks60 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks60
    {
        public P24832[] P248 { get; set; }
        public P81330[] P813 { get; set; }
        public P92231[] P9223 { get; set; }
    }

    public class P24832
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue412 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue412
    {
        public Value148 value { get; set; }
        public string type { get; set; }
    }

    public class Value148
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81330
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue413 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue413
    {
        public Value149 value { get; set; }
        public string type { get; set; }
    }

    public class Value149
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P92231
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue414 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue414
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9251
    {
        public Mainsnak230 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak230
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue415 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue415
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9282
    {
        public Mainsnak231 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak231
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue416 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue416
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9141
    {
        public Mainsnak232 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak232
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue417 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue417
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6683
    {
        public Mainsnak233 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak233
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue418 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue418
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7700
    {
        public Mainsnak234 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference61[] references { get; set; }
    }

    public class Mainsnak234
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue419 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue419
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference61
    {
        public string hash { get; set; }
        public Snaks61 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks61
    {
        public P24833[] P248 { get; set; }
        public P2144[] P214 { get; set; }
        public P81331[] P813 { get; set; }
    }

    public class P24833
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue420 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue420
    {
        public Value150 value { get; set; }
        public string type { get; set; }
    }

    public class Value150
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2144
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue421 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue421
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81331
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue422 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue422
    {
        public Value151 value { get; set; }
        public string type { get; set; }
    }

    public class Value151
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P5617
    {
        public Mainsnak235 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak235
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue423 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue423
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1449
    {
        public Mainsnak236 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak236
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue424 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue424
    {
        public Value152 value { get; set; }
        public string type { get; set; }
    }

    public class Value152
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P737
    {
        public Mainsnak237 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak237
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue425 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue425
    {
        public Value153 value { get; set; }
        public string type { get; set; }
    }

    public class Value153
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P18
    {
        public Mainsnak238 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak238
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue426 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue426
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9507
    {
        public Mainsnak239 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak239
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue427 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue427
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9522
    {
        public Mainsnak240 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak240
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue428 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue428
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9563
    {
        public Mainsnak241 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak241
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue429 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue429
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9493
    {
        public Mainsnak242 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference62[] references { get; set; }
    }

    public class Mainsnak242
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue430 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue430
    {
        public Value154 value { get; set; }
        public string type { get; set; }
    }

    public class Value154
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference62
    {
        public string hash { get; set; }
        public Snaks62 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks62
    {
        public P85411[] P854 { get; set; }
    }

    public class P85411
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue431 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue431
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6379
    {
        public Mainsnak243 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference63[] references { get; set; }
    }

    public class Mainsnak243
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue432 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue432
    {
        public Value155 value { get; set; }
        public string type { get; set; }
    }

    public class Value155
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference63
    {
        public string hash { get; set; }
        public Snaks63 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks63
    {
        public P3452[] P3452 { get; set; }
        public P46565[] P4656 { get; set; }
        public P9152[] P9152 { get; set; }
        public P81332[] P813 { get; set; }
        public P181012[] P1810 { get; set; }
        public P14763[] P1476 { get; set; }
        public P85412[] P854 { get; set; }
    }

    public class P3452
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue433 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue433
    {
        public Value156 value { get; set; }
        public string type { get; set; }
    }

    public class Value156
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P46565
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue434 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue434
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9152
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue435 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue435
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81332
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue436 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue436
    {
        public Value157 value { get; set; }
        public string type { get; set; }
    }

    public class Value157
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P181012
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue437 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue437
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P14763
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue438 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue438
    {
        public Value158 value { get; set; }
        public string type { get; set; }
    }

    public class Value158
    {
        public string text { get; set; }
        public string language { get; set; }
    }

    public class P85412
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue439 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue439
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9619
    {
        public Mainsnak244 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak244
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue440 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue440
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4985
    {
        public Mainsnak245 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak245
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue441 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue441
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P101
    {
        public Mainsnak246 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference64[] references { get; set; }
    }

    public class Mainsnak246
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue442 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue442
    {
        public Value159 value { get; set; }
        public string type { get; set; }
    }

    public class Value159
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference64
    {
        public string hash { get; set; }
        public Snaks64 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks64
    {
        public P14324[] P143 { get; set; }
        public P46566[] P4656 { get; set; }
        public P24834[] P248 { get; set; }
        public P6913[] P691 { get; set; }
        public P81333[] P813 { get; set; }
    }

    public class P14324
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue443 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue443
    {
        public Value160 value { get; set; }
        public string type { get; set; }
    }

    public class Value160
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P46566
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue444 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue444
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P24834
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue445 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue445
    {
        public Value161 value { get; set; }
        public string type { get; set; }
    }

    public class Value161
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P6913
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue446 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue446
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81333
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue447 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue447
    {
        public Value162 value { get; set; }
        public string type { get; set; }
    }

    public class Value162
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P9337
    {
        public Mainsnak247 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak247
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue448 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue448
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9686
    {
        public Mainsnak248 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak248
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue449 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue449
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P4084
    {
        public Mainsnak249 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak249
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue450 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue450
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9780
    {
        public Mainsnak250 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak250
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue451 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue451
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9807
    {
        public Mainsnak251 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak251
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue452 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue452
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7212
    {
        public Mainsnak252 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak252
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue453 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue453
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9918
    {
        public Mainsnak253 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak253
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue454 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue454
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9984
    {
        public Mainsnak254 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak254
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue455 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue455
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P91521
    {
        public Mainsnak255 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers16 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference65[] references { get; set; }
    }

    public class Mainsnak255
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue456 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue456
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers16
    {
        public P195[] P195 { get; set; }
    }

    public class P195
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue457 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue457
    {
        public Value163 value { get; set; }
        public string type { get; set; }
    }

    public class Value163
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Reference65
    {
        public string hash { get; set; }
        public Snaks65 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks65
    {
        public P24835[] P248 { get; set; }
        public P81334[] P813 { get; set; }
        public P181013[] P1810 { get; set; }
    }

    public class P24835
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue458 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue458
    {
        public Value164 value { get; set; }
        public string type { get; set; }
    }

    public class Value164
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P81334
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue459 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue459
    {
        public Value165 value { get; set; }
        public string type { get; set; }
    }

    public class Value165
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P181013
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue460 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue460
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10242
    {
        public Mainsnak256 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers17 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak256
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue461 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue461
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers17
    {
        public P1932[] P1932 { get; set; }
    }

    public class P1932
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue462 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue462
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8349
    {
        public Mainsnak257 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak257
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue463 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue463
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9466
    {
        public Mainsnak258 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak258
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue464 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue464
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P7305
    {
        public Mainsnak259 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak259
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue465 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue465
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10297
    {
        public Mainsnak260 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak260
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue466 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue466
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6645
    {
        public Mainsnak261 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak261
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue467 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue467
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1260
    {
        public Mainsnak262 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak262
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue468 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue468
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P701
    {
        public Mainsnak263 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak263
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue469 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue469
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10141
    {
        public Mainsnak264 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak264
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue470 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue470
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10553
    {
        public Mainsnak265 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak265
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue471 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue471
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8591
    {
        public Mainsnak266 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak266
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue472 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue472
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8410
    {
        public Mainsnak267 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak267
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue473 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue473
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P6385
    {
        public Mainsnak268 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak268
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue474 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue474
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10565
    {
        public Mainsnak269 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers18 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak269
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue475 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue475
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Qualifiers18
    {
        public P181014[] P1810 { get; set; }
    }

    public class P181014
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue476 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue476
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9495
    {
        public Mainsnak270 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak270
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue477 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue477
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10266
    {
        public Mainsnak271 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak271
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue478 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue478
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10883
    {
        public Mainsnak272 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak272
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue479 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue479
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P8168
    {
        public Mainsnak273 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak273
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue480 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue480
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10227
    {
        public Mainsnak274 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference66[] references { get; set; }
    }

    public class Mainsnak274
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue481 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue481
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference66
    {
        public string hash { get; set; }
        public Snaks66 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks66
    {
        public P24836[] P248 { get; set; }
        public P2145[] P214 { get; set; }
        public P81335[] P813 { get; set; }
    }

    public class P24836
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue482 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue482
    {
        public Value166 value { get; set; }
        public string type { get; set; }
    }

    public class Value166
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2145
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue483 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue483
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81335
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue484 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue484
    {
        public Value167 value { get; set; }
        public string type { get; set; }
    }

    public class Value167
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P10021
    {
        public Mainsnak275 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference67[] references { get; set; }
    }

    public class Mainsnak275
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue485 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue485
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference67
    {
        public string hash { get; set; }
        public Snaks67 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks67
    {
        public P24837[] P248 { get; set; }
        public P2146[] P214 { get; set; }
        public P81336[] P813 { get; set; }
    }

    public class P24837
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue486 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue486
    {
        public Value168 value { get; set; }
        public string type { get; set; }
    }

    public class Value168
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P2146
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue487 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue487
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81336
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue488 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue488
    {
        public Value169 value { get; set; }
        public string type { get; set; }
    }

    public class Value169
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P10527
    {
        public Mainsnak276 mainsnak { get; set; }
        public string type { get; set; }
        public Qualifiers19 qualifiers { get; set; }
        public string[] qualifiersorder { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
        public Reference68[] references { get; set; }
    }

    public class Mainsnak276
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue489 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue489
    {
        public Value170 value { get; set; }
        public string type { get; set; }
    }

    public class Value170
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class Qualifiers19
    {
        public P181015[] P1810 { get; set; }
    }

    public class P181015
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue490 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue490
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Reference68
    {
        public string hash { get; set; }
        public Snaks68 snaks { get; set; }
        public string[] snaksorder { get; set; }
    }

    public class Snaks68
    {
        public P24838[] P248 { get; set; }
        public P89741[] P8974 { get; set; }
        public P81337[] P813 { get; set; }
    }

    public class P24838
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue491 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue491
    {
        public Value171 value { get; set; }
        public string type { get; set; }
    }

    public class Value171
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P89741
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue492 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue492
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P81337
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue493 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue493
    {
        public Value172 value { get; set; }
        public string type { get; set; }
    }

    public class Value172
    {
        public string time { get; set; }
        public int timezone { get; set; }
        public int before { get; set; }
        public int after { get; set; }
        public int precision { get; set; }
        public string calendarmodel { get; set; }
    }

    public class P7400
    {
        public Mainsnak277 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak277
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue494 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue494
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P1299
    {
        public Mainsnak278 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak278
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue495 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue495
    {
        public Value173 value { get; set; }
        public string type { get; set; }
    }

    public class Value173
    {
        public string entitytype { get; set; }
        public int numericid { get; set; }
        public string id { get; set; }
    }

    public class P11156
    {
        public Mainsnak279 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak279
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue496 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue496
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P10302
    {
        public Mainsnak280 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak280
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue497 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue497
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P9247
    {
        public Mainsnak281 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak281
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue498 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue498
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P11249
    {
        public Mainsnak282 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak282
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue499 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue499
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P114961
    {
        public Mainsnak283 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak283
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue500 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue500
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class P2607
    {
        public Mainsnak284 mainsnak { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string rank { get; set; }
    }

    public class Mainsnak284
    {
        public string snaktype { get; set; }
        public string property { get; set; }
        public string hash { get; set; }
        public Datavalue501 datavalue { get; set; }
        public string datatype { get; set; }
    }

    public class Datavalue501
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Sitelinks
    {
        public Abwiki abwiki { get; set; }
        public Afwiki afwiki { get; set; }
        public Afwikiquote afwikiquote { get; set; }
        public Alswiki alswiki { get; set; }
        public Amwiki amwiki { get; set; }
        public Anwiki anwiki { get; set; }
        public Arcwiki arcwiki { get; set; }
        public Arwiki arwiki { get; set; }
        public Arwikiquote arwikiquote { get; set; }
        public Arywiki arywiki { get; set; }
        public Arzwiki arzwiki { get; set; }
        public Astwiki astwiki { get; set; }
        public Avkwiki avkwiki { get; set; }
        public Avwiki avwiki { get; set; }
        public Aywiki aywiki { get; set; }
        public Azbwiki azbwiki { get; set; }
        public Azwiki azwiki { get; set; }
        public Azwikiquote azwikiquote { get; set; }
        public Barwiki barwiki { get; set; }
        public Bat_Smgwiki bat_smgwiki { get; set; }
        public Bawiki bawiki { get; set; }
        public Bclwiki bclwiki { get; set; }
        public Be_X_Oldwiki be_x_oldwiki { get; set; }
        public Bewiki bewiki { get; set; }
        public Bgwiki bgwiki { get; set; }
        public Bgwikiquote bgwikiquote { get; set; }
        public Bhwiki bhwiki { get; set; }
        public Biwiki biwiki { get; set; }
        public Bnwiki bnwiki { get; set; }
        public Brwiki brwiki { get; set; }
        public Bswiki bswiki { get; set; }
        public Bswikiquote bswikiquote { get; set; }
        public Bxrwiki bxrwiki { get; set; }
        public Cawiki cawiki { get; set; }
        public Cawikiquote cawikiquote { get; set; }
        public Cawikisource cawikisource { get; set; }
        public Cbk_Zamwiki cbk_zamwiki { get; set; }
        public Cebwiki cebwiki { get; set; }
        public Cewiki cewiki { get; set; }
        public Ckbwiki ckbwiki { get; set; }
        public Commonswiki commonswiki { get; set; }
        public Cowiki cowiki { get; set; }
        public Crhwiki crhwiki { get; set; }
        public Cswiki cswiki { get; set; }
        public Cswikiquote cswikiquote { get; set; }
        public Cswikisource cswikisource { get; set; }
        public Cywiki cywiki { get; set; }
        public Dawiki dawiki { get; set; }
        public Dewiki dewiki { get; set; }
        public Dewikiquote dewikiquote { get; set; }
        public Dewikisource dewikisource { get; set; }
        public Diqwiki diqwiki { get; set; }
        public Elwiki elwiki { get; set; }
        public Enwiki enwiki { get; set; }
        public Enwikiquote enwikiquote { get; set; }
        public Enwikisource enwikisource { get; set; }
        public Eowiki eowiki { get; set; }
        public Eowikiquote eowikiquote { get; set; }
        public Eswiki eswiki { get; set; }
        public Eswikiquote eswikiquote { get; set; }
        public Eswikisource eswikisource { get; set; }
        public Etwiki etwiki { get; set; }
        public Etwikiquote etwikiquote { get; set; }
        public Euwiki euwiki { get; set; }
        public Extwiki extwiki { get; set; }
        public Fawiki fawiki { get; set; }
        public Fawikiquote fawikiquote { get; set; }
        public Fiu_Vrowiki fiu_vrowiki { get; set; }
        public Fiwiki fiwiki { get; set; }
        public Fiwikisource fiwikisource { get; set; }
        public Fowiki fowiki { get; set; }
        public Frpwiki frpwiki { get; set; }
        public Frrwiki frrwiki { get; set; }
        public Frwiki frwiki { get; set; }
        public Frwikiquote frwikiquote { get; set; }
        public Frwikisource frwikisource { get; set; }
        public Fywiki fywiki { get; set; }
        public Ganwiki ganwiki { get; set; }
        public Gawiki gawiki { get; set; }
        public Gcrwiki gcrwiki { get; set; }
        public Gdwiki gdwiki { get; set; }
        public Glwiki glwiki { get; set; }
        public Glwikiquote glwikiquote { get; set; }
        public Gnwiki gnwiki { get; set; }
        public Hawiki hawiki { get; set; }
        public Hewiki hewiki { get; set; }
        public Hewikiquote hewikiquote { get; set; }
        public Hifwiki hifwiki { get; set; }
        public Hrwiki hrwiki { get; set; }
        public Hrwikiquote hrwikiquote { get; set; }
        public Huwiki huwiki { get; set; }
        public Huwikiquote huwikiquote { get; set; }
        public Hywiki hywiki { get; set; }
        public Hywikiquote hywikiquote { get; set; }
        public Hywikisource hywikisource { get; set; }
        public Iawiki iawiki { get; set; }
        public Idwiki idwiki { get; set; }
        public Iewiki iewiki { get; set; }
        public Ilowiki ilowiki { get; set; }
        public Iowiki iowiki { get; set; }
        public Iswiki iswiki { get; set; }
        public Itwiki itwiki { get; set; }
        public Itwikiquote itwikiquote { get; set; }
        public Itwikisource itwikisource { get; set; }
        public Jamwiki jamwiki { get; set; }
        public Jawiki jawiki { get; set; }
        public Jawikiquote jawikiquote { get; set; }
        public Jbowiki jbowiki { get; set; }
        public Jvwiki jvwiki { get; set; }
        public Kaawiki kaawiki { get; set; }
        public Kabwiki kabwiki { get; set; }
        public Kawiki kawiki { get; set; }
        public Kawikiquote kawikiquote { get; set; }
        public Kbdwiki kbdwiki { get; set; }
        public Kbpwiki kbpwiki { get; set; }
        public Kcgwiki kcgwiki { get; set; }
        public Kkwiki kkwiki { get; set; }
        public Kowiki kowiki { get; set; }
        public Kowikiquote kowikiquote { get; set; }
        public Kowikisource kowikisource { get; set; }
        public Kuwiki kuwiki { get; set; }
        public Kwwiki kwwiki { get; set; }
        public Kywiki kywiki { get; set; }
        public Ladwiki ladwiki { get; set; }
        public Lawiki lawiki { get; set; }
        public Lbwiki lbwiki { get; set; }
        public Lfnwiki lfnwiki { get; set; }
        public Liwiki liwiki { get; set; }
        public Lldwiki lldwiki { get; set; }
        public Lmowiki lmowiki { get; set; }
        public Ltwiki ltwiki { get; set; }
        public Ltwikiquote ltwikiquote { get; set; }
        public Lvwiki lvwiki { get; set; }
        public Mgwiki mgwiki { get; set; }
        public Mhrwiki mhrwiki { get; set; }
        public Minwiki minwiki { get; set; }
        public Mkwiki mkwiki { get; set; }
        public Mlwiki mlwiki { get; set; }
        public Mnwiki mnwiki { get; set; }
        public Mrjwiki mrjwiki { get; set; }
        public Mrwiki mrwiki { get; set; }
        public Mswiki mswiki { get; set; }
        public Mtwiki mtwiki { get; set; }
        public Mwlwiki mwlwiki { get; set; }
        public Myvwiki myvwiki { get; set; }
        public Mywiki mywiki { get; set; }
        public Mznwiki mznwiki { get; set; }
        public Nahwiki nahwiki { get; set; }
        public Nawiki nawiki { get; set; }
        public Ndswiki ndswiki { get; set; }
        public Newwiki newwiki { get; set; }
        public Nlwiki nlwiki { get; set; }
        public Nlwikiquote nlwikiquote { get; set; }
        public Nnwiki nnwiki { get; set; }
        public Novwiki novwiki { get; set; }
        public Nowiki nowiki { get; set; }
        public Nowikiquote nowikiquote { get; set; }
        public Ocwiki ocwiki { get; set; }
        public Oswiki oswiki { get; set; }
        public Pagwiki pagwiki { get; set; }
        public Pamwiki pamwiki { get; set; }
        public Pawiki pawiki { get; set; }
        public Pcdwiki pcdwiki { get; set; }
        public Plwiki plwiki { get; set; }
        public Plwikiquote plwikiquote { get; set; }
        public Plwikisource plwikisource { get; set; }
        public Pmswiki pmswiki { get; set; }
        public Pnbwiki pnbwiki { get; set; }
        public Ptwiki ptwiki { get; set; }
        public Ptwikiquote ptwikiquote { get; set; }
        public Ptwikisource ptwikisource { get; set; }
        public Quwiki quwiki { get; set; }
        public Roa_Rupwiki roa_rupwiki { get; set; }
        public Rowiki rowiki { get; set; }
        public Rowikiquote rowikiquote { get; set; }
        public Ruewiki ruewiki { get; set; }
        public Ruwiki ruwiki { get; set; }
        public Ruwikinews ruwikinews { get; set; }
        public Ruwikiquote ruwikiquote { get; set; }
        public Ruwikisource ruwikisource { get; set; }
        public Sahwiki sahwiki { get; set; }
        public Satwiki satwiki { get; set; }
        public Scnwiki scnwiki { get; set; }
        public Scowiki scowiki { get; set; }
        public Scwiki scwiki { get; set; }
        public Shwiki shwiki { get; set; }
        public Simplewiki simplewiki { get; set; }
        public Skwiki skwiki { get; set; }
        public Skwikiquote skwikiquote { get; set; }
        public Slwiki slwiki { get; set; }
        public Slwikiquote slwikiquote { get; set; }
        public Slwikisource slwikisource { get; set; }
        public Sqwiki sqwiki { get; set; }
        public Sqwikiquote sqwikiquote { get; set; }
        public Srwiki srwiki { get; set; }
        public Srwikiquote srwikiquote { get; set; }
        public Svwiki svwiki { get; set; }
        public Swwiki swwiki { get; set; }
        public Szywiki szywiki { get; set; }
        public Tawiki tawiki { get; set; }
        public Tawikiquote tawikiquote { get; set; }
        public Tgwiki tgwiki { get; set; }
        public Thwiki thwiki { get; set; }
        public Tkwiki tkwiki { get; set; }
        public Tlwiki tlwiki { get; set; }
        public Trwiki trwiki { get; set; }
        public Trwikiquote trwikiquote { get; set; }
        public Ttwiki ttwiki { get; set; }
        public Tumwiki tumwiki { get; set; }
        public Ukwiki ukwiki { get; set; }
        public Ukwikiquote ukwikiquote { get; set; }
        public Ukwikisource ukwikisource { get; set; }
        public Urwiki urwiki { get; set; }
        public Uzwiki uzwiki { get; set; }
        public Vecwiki vecwiki { get; set; }
        public Vepwiki vepwiki { get; set; }
        public Viwiki viwiki { get; set; }
        public Viwikiquote viwikiquote { get; set; }
        public Vowiki vowiki { get; set; }
        public Warwiki warwiki { get; set; }
        public Wuuwiki wuuwiki { get; set; }
        public Xmfwiki xmfwiki { get; set; }
        public Yiwiki yiwiki { get; set; }
        public Yowiki yowiki { get; set; }
        public Zawiki zawiki { get; set; }
        public Zh_Classicalwiki zh_classicalwiki { get; set; }
        public Zh_Min_Nanwiki zh_min_nanwiki { get; set; }
        public Zh_Yuewiki zh_yuewiki { get; set; }
        public Zhwiki zhwiki { get; set; }
        public Zhwikiquote zhwikiquote { get; set; }
    }

    public class Abwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Afwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Afwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Alswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Amwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Anwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Arcwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Arwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Arwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Arywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Arzwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Astwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Avkwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Avwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Aywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Azbwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Azwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Azwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Barwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bat_Smgwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bclwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Be_X_Oldwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bgwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bgwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bhwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Biwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Brwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bswikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Bxrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cawikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cawikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cbk_Zamwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cebwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ckbwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Commonswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Crhwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cswikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cswikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Cywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Dawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Dewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Dewikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Dewikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Diqwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Elwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Enwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Enwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Enwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Eowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Eowikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Eswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Eswikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Eswikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Etwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Etwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Euwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Extwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fawikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fiu_Vrowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fiwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fiwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Frpwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Frrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Frwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Frwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Frwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Fywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ganwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Gawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Gcrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Gdwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Glwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Glwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Gnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hewikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hifwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hrwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Huwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Huwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hywikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Hywikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Iawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Idwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Iewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ilowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Iowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Iswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Itwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Itwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Itwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Jamwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Jawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Jawikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Jbowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Jvwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kaawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kabwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kawikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kbdwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kbpwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kcgwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kkwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kowikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kowikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kuwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kwwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Kywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ladwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lbwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lfnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Liwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lldwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lmowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ltwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ltwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Lvwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mgwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mhrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Minwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mkwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mlwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mrjwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mrwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mtwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mwlwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Myvwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Mznwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nahwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ndswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Newwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nlwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nlwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Novwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Nowikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ocwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Oswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pagwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pamwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pcdwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Plwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Plwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Plwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pmswiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Pnbwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ptwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ptwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ptwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Quwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Roa_Rupwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Rowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Rowikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ruewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ruwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ruwikinews
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ruwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ruwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Sahwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Satwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Scnwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Scowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Scwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Shwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Simplewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Skwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Skwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Slwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Slwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Slwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Sqwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Sqwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Srwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public string[] badges { get; set; }
        public string url { get; set; }
    }

    public class Srwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Svwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Swwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Szywiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tawikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tgwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Thwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tkwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tlwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Trwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Trwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ttwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Tumwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ukwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ukwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Ukwikisource
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Urwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Uzwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Vecwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Vepwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Viwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Viwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Vowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Warwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Wuuwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Xmfwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Yiwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Yowiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zawiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zh_Classicalwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zh_Min_Nanwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zh_Yuewiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zhwiki
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

    public class Zhwikiquote
    {
        public string site { get; set; }
        public string title { get; set; }
        public object[] badges { get; set; }
        public string url { get; set; }
    }

}
