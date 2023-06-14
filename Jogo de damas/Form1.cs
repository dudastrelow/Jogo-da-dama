using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_damas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Button()
        {
            /*if(aa.Text == "" || ab.Text == "" || ac.Text == "" || ad.Text == "" || ae.Text == "" || af.Text == "" || ag.Text == "" || ah.Text == "" ||
               ba.Text == "" || bb.Text == "" || bc.Text == "" || bd.Text == "" || be.Text == "" || bf.Text == "" || bg.Text == "" || bh.Text == "" ||
               ca.Text == "" || cb.Text == "" || cc.Text == "" || cd.Text == "" || ce.Text == "" || cf.Text == "" || cg.Text == "" || ch.Text == "" ||
               da.Text == "" || db.Text == "" || dc.Text == "" || dd.Text == "" || de.Text == "" || df.Text == "" || dg.Text == "" || dh.Text == "" ||
               ea.Text == "" || eb.Text == "" || ec.Text == "" || ed.Text == "" || ee.Text == "" || ef.Text == "" || eg.Text == "" || eh.Text == "" ||
               fa.Text == "" || fb.Text == "" || fc.Text == "" || fd.Text == "" || fe.Text == "" || ff.Text == "" || fg.Text == "" || fh.Text == "" ||
               ga.Text == "" || gb.Text == "" || gc.Text == "" || gd.Text == "" || ge.Text == "" || gf.Text == "" || gg.Text == "" || gh.Text == "" ||
               ha.Text == "" || hb.Text == "" || hc.Text == "" || hd.Text == "" || he.Text == "" || hf.Text == "" || hg.Text == "" || hh.Text == "")
            {
            }*/
        }
        

        private void aa_Click(object sender, EventArgs e)
        {
            Peao p = new Peao(aa.Text, ab.Text, ac.Text, ad.Text, ae.Text, af.Text, ag.Text, ah.Text, ba.Text, bb.Text, bc.Text, bd.Text, be.Text, bf.Text, bg.Text, bh.Text, ca.Text, cb.Text, cc.Text, cd.Text, ce.Text, cf.Text, cg.Text, ch.Text, da.Text, db.Text, dc.Text, dd.Text, de.Text, df.Text, dg.Text, dh.Text, ea.Text, eb.Text, ec.Text, ed.Text, ee.Text, ef.Text, eg.Text, eh.Text, fa.Text, fb.Text, fc.Text, fd.Text, fe.Text, ff.Text, fg.Text, fh.Text, ga.Text, gb.Text, gc.Text, gd.Text, ge.Text, gf.Text, gg.Text, gh.Text, ha.Text, hb.Text, hc.Text, hd.Text, he.Text, hf.Text, hg.Text, hh.Text);
            if (aa.Text == "")
            {
                aa.Enabled = false;
            }
            if(aa.Text != "")
            {
                if(bb.Text == "")
                {
                    aa.Text = "";
                    bb.Text = "x";
                }
            }
        }
        private void button64_Click(object sender, EventArgs e)
        {
            
        }

        private void button62_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Peao p = new Peao(aa.Text, ab.Text, ac.Text, ad.Text, ae.Text, af.Text, ag.Text, ah.Text, ba.Text, bb.Text, bc.Text, bd.Text, be.Text, bf.Text, bg.Text, bh.Text, ca.Text, cb.Text, cc.Text, cd.Text, ce.Text, cf.Text, cg.Text, ch.Text, da.Text, db.Text, dc.Text, dd.Text, de.Text, df.Text, dg.Text, dh.Text, ea.Text, eb.Text, ec.Text, ed.Text, ee.Text, ef.Text, eg.Text, eh.Text, fa.Text, fb.Text, fc.Text, fd.Text, fe.Text, ff.Text, fg.Text, fh.Text, ga.Text, gb.Text, gc.Text, gd.Text, ge.Text, gf.Text, gg.Text, gh.Text, ha.Text, hb.Text, hc.Text, hd.Text, he.Text, hf.Text, hg.Text, hh.Text);
            
            if (cc.Text != "")
            {
                if (bd.Text == "")
                {
                    if (bd.Enabled == true)
                    {

                        cc.Text = "";
                        bd.Text = "x";
                    }
                }
                else if (dd.Text == "")
                {
                    if (dd.Enabled == true)
                    {
                        {
                            cc.Text = "";
                            dd.Text = "x";
                        }
                    }

                }
            }
            
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Peao p = new Peao(aa.Text, ab.Text, ac.Text, ad.Text, ae.Text, af.Text, ag.Text, ah.Text, ba.Text, bb.Text, bc.Text, bd.Text, be.Text, bf.Text, bg.Text, bh.Text, ca.Text, cb.Text, cc.Text, cd.Text, ce.Text, cf.Text, cg.Text, ch.Text, da.Text, db.Text, dc.Text, dd.Text, de.Text, df.Text, dg.Text, dh.Text, ea.Text, eb.Text, ec.Text, ed.Text, ee.Text, ef.Text, eg.Text, eh.Text, fa.Text, fb.Text, fc.Text, fd.Text, fe.Text, ff.Text, fg.Text, fh.Text, ga.Text, gb.Text, gc.Text, gd.Text, ge.Text, gf.Text, gg.Text, gh.Text, ha.Text, hb.Text, hc.Text, hd.Text, he.Text, hf.Text, hg.Text, hh.Text);
            if (ac.Text == "")
            {
                ac.Enabled = false;
            }
            if (ac.Text != "")
            {
                if (bd.Text == "")
                {
                    ac.Text = "";
                    bd.Text = "x";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Peao p = new Peao(aa.Text, ab.Text, ac.Text, ad.Text, ae.Text, af.Text, ag.Text, ah.Text, ba.Text, bb.Text, bc.Text, bd.Text, be.Text, bf.Text, bg.Text, bh.Text, ca.Text, cb.Text, cc.Text, cd.Text, ce.Text, cf.Text, cg.Text, ch.Text, da.Text, db.Text, dc.Text, dd.Text, de.Text, df.Text, dg.Text, dh.Text, ea.Text, eb.Text, ec.Text, ed.Text, ee.Text, ef.Text, eg.Text, eh.Text, fa.Text, fb.Text, fc.Text, fd.Text, fe.Text, ff.Text, fg.Text, fh.Text, ga.Text, gb.Text, gc.Text, gd.Text, ge.Text, gf.Text, gg.Text, gh.Text, ha.Text, hb.Text, hc.Text, hd.Text, he.Text, hf.Text, hg.Text, hh.Text);
            if (ab.Text == " ")
            {
                ab.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        

        private void hh_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fh_Click(object sender, EventArgs e)
        {

        }

        private void dh_Click(object sender, EventArgs e)
        {

        }

        private void bh_Click(object sender, EventArgs e)
        {

        }

        private void gg_Click(object sender, EventArgs e)
        {

        }

        private void eg_Click(object sender, EventArgs e)
        {

        }

        private void cg_Click(object sender, EventArgs e)
        {

        }

        private void ag_Click(object sender, EventArgs e)
        {

        }

        private void ff_Click(object sender, EventArgs e)
        {

        }

        private void df_Click(object sender, EventArgs e)
        {

        }

        private void ge_Click(object sender, EventArgs e)
        {

        }

        private void ee_Click(object sender, EventArgs e)
        {

        }

        private void hb_Click(object sender, EventArgs e)
        {

        }

        private void fb_Click(object sender, EventArgs e)
        {

        }

        private void bb_Click(object sender, EventArgs e)
        {

        }

        private void ga_Click(object sender, EventArgs e)
        {

        }

        private void ea_Click(object sender, EventArgs e)
        {

        }

        private void ca_Click(object sender, EventArgs e)
        {

        }
    }
}
