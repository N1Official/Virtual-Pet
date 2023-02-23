<?php

namespace Database\Seeders;

use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class MoodSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table("moods")->insert([
            'mood'=> 'Good',
        ]);
      
        DB::table("moods")->insert([
            'mood'=> 'Tired',
        ]);
        
        DB::table("moods")->insert([
            'mood'=> 'Mad',
        ]);
       
        DB::table("moods")->insert([
            'mood'=> 'Thankful',
        ]);

        DB::table("moods")->insert([
            'mood'=> 'Touched',
        ]);

        DB::table("moods")->insert([
            'mood'=> 'Lonely',
        ]);

        DB::table("moods")->insert([
            'mood'=> 'Loved',
        ]);

        DB::table("moods")->insert([
            'mood'=> 'Stressed',
        ]);

        DB::table("moods")->insert([
            'mood'=> 'Bored',
        ]);
    }
}
