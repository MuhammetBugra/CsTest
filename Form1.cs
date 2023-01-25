using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox {
    public partial class Form1 : Form {
    public Form1() {
    InitializeComponent(); }
    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
    if(checkBox1.Checked==true) { 
    label1.Text = "sigara içiyorsunuz"; }
    else {
    label1.Text = "sigara içmiyorsunuz"; } }
    private void button1_Click(object sender, EventArgs e) {
    string bildigi_diller="";
    if(checkBox2.Checked==true) {
    bildigi_diller =bildigi_diller+","+checkBox2.Text; }
    if(checkBox3.Checked==true) {
    bildigi_diller =bildigi_diller+","+checkBox3.Text; }
    if(checkBox4.Checked==true) {
    bildigi_diller =bildigi_diller+","+checkBox4.Text; }
    bildigi_diller=bildigi_diller.Substring(1);
    label2.Text = bildigi_diller; } } }
