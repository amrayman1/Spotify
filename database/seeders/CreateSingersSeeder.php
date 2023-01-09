<?php

namespace Database\Seeders;

use App\Models\Admin;
use App\Models\Singer;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class CreateSingersSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $siners = [
            [
                'name' => ' Singer',
                'email' => 'singer@odc.com',
                'password' => bcrypt('123456'),
            ],
        ];
        foreach ($siners as $key => $siner) {

            Singer::create($siner);
        }
    }
}