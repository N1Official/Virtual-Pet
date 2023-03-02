<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table("users")->insert([
            'username'=>'Mlevi0',
            'email' =>'magyarilevi0415@gmail.com',           
            'password'=>'valami',
            'firstName'=>'Levi',
            'lastName'=>'Magyari',
            'gender'=>'Male',
            'birthday'=>'2003-04-15',
            'phone'=>'06209983474',
            'address'=>'Sarlosfecske u 51',
            'city'=>'Budapest',
            'state'=>'Hungary',
            'zipcode'=>0000,
            'country'=>'Hungary',
        ]);
    }
}
